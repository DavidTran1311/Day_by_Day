using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_Trigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue, visualE;
    [SerializeField] private GameObject LilyTrigger;
    public bool triggerChecklist = false;
    private bool PlayerInRange;


    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    private void Awake()
    {
        PlayerInRange = false;
        visualCue.SetActive(false);
        visualE.SetActive(false);
    }

    private void Update()
    {
        if (PlayerInRange==true && !Dialogue_Manager.GetInstance().DialogueIsPlaying)
        {
            
            if (Input.GetKey(KeyCode.E))
            {
                Dialogue_Manager.GetInstance().EnterDialogueMode(inkJSON);
                Debug.Log("trigger check bitch");

            }

        }
        else 
        { 
            
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log("in range");

            PlayerInRange = true;
            visualE.SetActive(true);
            visualCue.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInRange = false;
            visualE.SetActive(false);
            visualCue.SetActive(false);
        }
    }
}
