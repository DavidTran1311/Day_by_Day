using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDoctorCall : MonoBehaviour
{
    private bool PlayerInRange;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    // Start is called before the first frame update
    void Start()
    {
        PlayerInRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerInRange == true && !Dialogue_Manager.GetInstance().DialogueIsPlaying)
        {
                Dialogue_Manager.GetInstance().EnterDialogueMode(inkJSON);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log("in range");

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
