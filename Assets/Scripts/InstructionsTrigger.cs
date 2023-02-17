using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsTrigger : MonoBehaviour
{
    [SerializeField] private GameObject visualCue, visualE, instructionPanel;
    private bool PlayerInRange;

    // Start is called before the first frame update
    void Start()
    {
        PlayerInRange = false;
        visualCue.SetActive(false);
        visualE.SetActive(false);
        instructionPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerInRange == true)
        {
            visualE.SetActive(true);
            visualCue.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                instructionPanel.SetActive(true);
                Time.timeScale = 0f;
            }

        }
        else
        {
            visualE.SetActive(false);
            visualCue.SetActive(false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            instructionPanel.SetActive(false);
            Time.timeScale = 1f;
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
