using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewspaperTrigger : MonoBehaviour
{
    [SerializeField] private GameObject visualCue, visualE, newspaperPanel;
    private bool PlayerInRange;

    // Start is called before the first frame update
    void Start()
    {
        PlayerInRange = false;
        visualCue.SetActive(false);
        visualE.SetActive(false);
        newspaperPanel.SetActive(false);
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
                newspaperPanel.SetActive(true);
                Time.timeScale = 0f;
            }

        }
        else
        {
            visualE.SetActive(false);
            visualCue.SetActive(false);
        }

        if (Input.GetKey(KeyCode.R))
        {
            newspaperPanel.SetActive(false);
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
