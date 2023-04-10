using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueSpace : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    public GameObject popUpPanel;

    // Start is called before the first frame update
    void Start()
    {
        popUpPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && !Dialogue_Manager.GetInstance().DialogueIsPlaying)
        {

            Dialogue_Manager.GetInstance().EnterDialogueMode(inkJSON);
        }
        else if (Input.GetKeyDown(KeyCode.E) && !Dialogue_Manager.GetInstance().DialogueIsPlaying)
        {
                EndWeek();
        }
    }

    public void EndWeek()
    {
        if (!Dialogue_Manager.GetInstance().DialogueIsPlaying)
        {
            popUpPanel.SetActive(true);
        }
    }

    public void EndWeekScreen()
    {
        SceneManager.LoadScene("EndScreenWeek3");
    }
}
