using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
public class Dialogue_Manager : MonoBehaviour
{

    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;

    private Story CurrentStory;

    private static Dialogue_Manager instance;

    [Header("Choices UI")]
    [SerializeField] private GameObject[] Choices;

    private TextMeshProUGUI[] ChoicesText;

    public bool DialogueIsPlaying { get; private set; }

    private void Awake()
    {
        if (instance!= null)
        {
            Debug.Log("found more than one");

        }
        instance=this;
    }

    public static Dialogue_Manager GetInstance()
    {
        
        return instance;

    }
    private void Start()
    {
        DialogueIsPlaying = false;
        dialoguePanel.SetActive(false);

        ChoicesText = new TextMeshProUGUI[Choices.Length];
        int index = 0;
        foreach(GameObject choice in Choices)
        {
            ChoicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
            index++;
        }
    }

    private void Update()
    {
        if (!DialogueIsPlaying)
        {
            return;
        }
        if (CurrentStory.currentChoices.Count==0 && Input.GetKeyDown(KeyCode.R))
        {
            ContinueStory();
        }
    }
    public void EnterDialogueMode(TextAsset inkJSON) {
        CurrentStory = new Story(inkJSON.text);
        DialogueIsPlaying = true;
        dialoguePanel.SetActive(true);

        ContinueStory();
    

        
    }
    private void ExitDialogueMode()
    {

        DialogueIsPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";

    }

    private void ContinueStory() {

        if (CurrentStory.canContinue)
        {
           
            dialogueText.text = CurrentStory.Continue();
            DisplayChoices();
        }
        else
        {
            
            ExitDialogueMode();
           
        }
    }

    private void DisplayChoices() {

        List<Choice> currentChoices = CurrentStory.currentChoices;
        if (currentChoices.Count > Choices.Length) {

            Debug.LogError("more choices were given than ui can support"+ currentChoices.Count);
        }
        int index = 0;
        foreach(Choice choice in currentChoices)
        {
            Choices[index].gameObject.SetActive(true);
            ChoicesText[index].text = choice.text;
            index++;

            StartCoroutine(SelectFirstChoice());
        }

        for(int i = index; i < Choices.Length; i++)
        {
            Choices[i].gameObject.SetActive(false);

        }
    }
    private IEnumerator SelectFirstChoice() {

        EventSystem.current.SetSelectedGameObject(null);
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(Choices[0].gameObject);
    }

    public void MakeChoice(int ChoiceIndex) {

        CurrentStory.ChooseChoiceIndex(ChoiceIndex);
        ContinueStory();
    }
}
