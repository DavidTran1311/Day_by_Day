using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_Trigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;
    private bool PlayerInRange;


    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    private void Awake()
    {
        PlayerInRange = false;
        visualCue.SetActive(false);
    }

    private void Update()
    {
        if (PlayerInRange==true && !Dialogue_Manager.GetInstance().DialogueIsPlaying)
        {
            visualCue.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                Dialogue_Manager.GetInstance().EnterDialogueMode(inkJSON); 

            }

        }
        else { visualCue.SetActive(false); }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInRange = false;
        }
    }
}
