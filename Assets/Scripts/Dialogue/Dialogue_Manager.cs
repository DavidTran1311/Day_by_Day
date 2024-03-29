using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dialogue_Manager : MonoBehaviour
{
    [Header("Params")]
    [SerializeField] private float typingSpeed = 0.04f;

    [Header("Load Globals JSON")]
    [SerializeField] private TextAsset loadGlobalsJSON;

    [Header("Dialogue UI")]
    [SerializeField] public GameObject dialoguePanel;
    [SerializeField] private GameObject continueIcon;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextMeshProUGUI displayNameText;
    [SerializeField] private TextMeshProUGUI displayNameColorText;
    [SerializeField] private Animator portraitAnimator;
    private bool submitButtonPressedThisFrame = false;

    private Story CurrentStory;

    private static Dialogue_Manager instance;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] Choices;

    private TextMeshProUGUI[] ChoicesText;

    [Header("Audio")]
    [SerializeField] private AudioClip[] dialogueTypingSoundClips;
    [Range(1, 10)]
    [SerializeField] private int frequencyLevel = 8;
    [SerializeField] private float minPitch = 1f;
    [Range(1, 4)]
    [SerializeField] private float maxPitch = 4f;
    [SerializeField] private bool stopAudioSource;

    private AudioSource audioSource;

    public bool DialogueIsPlaying { get; private set; }

    private bool canContinueToNextLine = false;

    private Coroutine displayLineCoroutine;

    private const string SPEAKER_TAG = "speaker";
    private const string PORTRAIT_TAG = "portrait";
    private const string LAYOUT_TAG = "layout";
    private const string SPEAKER_COLOR_TAG = "speaker_color";

    private Dialogue_Variables dialogueVariables;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("found more than one");

        }
        instance = this;

        dialogueVariables = new Dialogue_Variables(loadGlobalsJSON);
        audioSource = this.gameObject.AddComponent<AudioSource>();
    }

    public static Dialogue_Manager GetInstance()
    {

        return instance;

    }
    private void Start()
    {
        Cursor.visible = true;
        DialogueIsPlaying = false;
        dialoguePanel.SetActive(false);

        ChoicesText = new TextMeshProUGUI[Choices.Length];
        int index = 0;
        foreach (GameObject choice in Choices)
        {
            ChoicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            submitButtonPressedThisFrame = true;
        }

        if (!DialogueIsPlaying)
        {
            return;
        }
        if (canContinueToNextLine && CurrentStory.currentChoices.Count == 0 && submitButtonPressedThisFrame)
        {
            submitButtonPressedThisFrame = false;
            ContinueStory();
        }
    }
    public void EnterDialogueMode(TextAsset inkJSON)
    {
        CurrentStory = new Story(inkJSON.text);
        DialogueIsPlaying = true;
        dialoguePanel.SetActive(true);

        dialogueVariables.StartListening(CurrentStory);

        ContinueStory();



    }
    private IEnumerator ExitDialogueMode()
    {
        yield return new WaitForSeconds(0.2f);

        dialogueVariables.StopListening(CurrentStory);

        DialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";

    }

    private void ContinueStory()
    {

        if (CurrentStory.canContinue)
        {
            if (displayLineCoroutine != null)
            {
                StopCoroutine(displayLineCoroutine);
            }

            displayLineCoroutine = StartCoroutine(DisplayLine(CurrentStory.Continue()));


            //handle tags
            HandleTags(CurrentStory.currentTags);
        }
        else
        {

            StartCoroutine(ExitDialogueMode());

        }
    }

    private IEnumerator DisplayLine(string line)
    {
        dialogueText.text = "";
        dialogueText.maxVisibleCharacters = 500;

        continueIcon.SetActive(false);
        HideChoices();

        canContinueToNextLine = false;

        bool isAddingRichTextTag = false;

        foreach (char letter in line.ToCharArray())
        {

            if (submitButtonPressedThisFrame == true)
            {
                submitButtonPressedThisFrame = false;
                dialogueText.text = line;
                break;

            }


            if (letter == '<' || isAddingRichTextTag)
            {
                isAddingRichTextTag = true;
                dialogueText.text += letter;
                if (letter == '>')
                {
                    isAddingRichTextTag = false;
                }
            }
            else
            {

                dialogueText.maxVisibleCharacters += letter;
                PlayDialogueSound(dialogueText.maxVisibleCharacters);
                dialogueText.text += letter;
                yield return new WaitForSeconds(typingSpeed);
            }

        }

        continueIcon.SetActive(true);
        DisplayChoices();

        canContinueToNextLine = true;
    }

    private void PlayDialogueSound(int currentDisplayedCharacterCount)
    {
        if (currentDisplayedCharacterCount % frequencyLevel == 0)
        {
            if (stopAudioSource)
            {
                audioSource.Stop();
            }

            int randomIndex = Random.Range(0, dialogueTypingSoundClips.Length);
            AudioClip soundClip = dialogueTypingSoundClips[randomIndex];

            audioSource.volume = 0.1f;
            audioSource.pitch = Random.Range(minPitch, maxPitch);
            audioSource.PlayOneShot(soundClip);
        }
    }

    private void HideChoices()
    {
        foreach (GameObject choiceButton in Choices)
        {
            choiceButton.SetActive(false);
        }
    }

    private void HandleTags(List<string> currentTags)
    {
        foreach (string tag in currentTags)
        {
            string[] splitTag = tag.Split(':');
            if (splitTag.Length != 2)
            {
                Debug.LogError("Tag could not be appropriately parsed: " + tag);
            }
            string tagKey = splitTag[0].Trim();
            string tagValue = splitTag[1].Trim();

            switch (tagKey)
            {
                case SPEAKER_TAG:
                    displayNameText.text = tagValue;
                    break;
                case PORTRAIT_TAG:
                    portraitAnimator.Play(tagValue);
                    break;
                case SPEAKER_COLOR_TAG:
                    Color speakerColor;
                    tagValue = "#" + tagValue;
                    if (ColorUtility.TryParseHtmlString(tagValue, out speakerColor))
                    {
                        displayNameColorText.color = speakerColor;
                    }
                    break;
                default:
                    Debug.LogWarning("Tag came in but is currently being handled: " + tag);
                    break;
            }
        }
    }

    private void DisplayChoices()
    {

        List<Choice> currentChoices = CurrentStory.currentChoices;
        if (currentChoices.Count > Choices.Length)
        {

            Debug.LogError("more choices were given than ui can support" + currentChoices.Count);
        }
            int index = 0;
        foreach (Choice choice in currentChoices)
        {
            Choices[index].gameObject.SetActive(true);
            ChoicesText[index].text = choice.text;
            index++;

            StartCoroutine(SelectFirstChoice());
        }

        for (int i = index; i < Choices.Length; i++)
        {
            Choices[i].gameObject.SetActive(false);

        }
    }

    private IEnumerator SelectFirstChoice()
{

    EventSystem.current.SetSelectedGameObject(null);
    yield return new WaitForEndOfFrame();
    EventSystem.current.SetSelectedGameObject(Choices[0].gameObject);
}

public void MakeChoice(int ChoiceIndex)
{

    if (canContinueToNextLine)
    {
        CurrentStory.ChooseChoiceIndex(ChoiceIndex);
        ContinueStory();
    }

}
    public Ink.Runtime.Object GetVariableState(string variableName)
    {
        Ink.Runtime.Object variableValue = null;
        dialogueVariables.variables.TryGetValue(variableName, out variableValue);
        if (variableValue == null)
        {
            Debug.LogWarning("Ink Variable was found to be null: " + variableName);
        }
        return variableValue;
    }

}
