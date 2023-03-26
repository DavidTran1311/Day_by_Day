using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IllustrationPopups : MonoBehaviour
{
    [SerializeField] private GameObject illustration;
    private bool PlayerInRange;

    void Start()
    {
        illustration.SetActive(false);
    }


    private void Update()
    {
        imagePopup();
    }

    void imagePopup()
    {
        if (PlayerInRange == true && Dialogue_Manager.GetInstance().DialogueIsPlaying)
        {
            if (Input.GetKey(KeyCode.E))
            {
                illustration.SetActive(true);
            }
        }
        else
        {
            illustration.SetActive(false);
        }
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
