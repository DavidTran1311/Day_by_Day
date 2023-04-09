using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BreakroomWeek3 : MonoBehaviour
{
    private bool PlayerInRange;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    [SerializeField] private GameObject deezNuts;
    //Collider col;

    // Start is called before the first frame update
    void Start()
    {
        PlayerInRange = false;
        //col = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerInRange == true && !Dialogue_Manager.GetInstance().DialogueIsPlaying && deezNuts.GetComponent<BoxCollider2D>().isTrigger == true)
        {
            Dialogue_Manager.GetInstance().EnterDialogueMode(inkJSON);

            // i literally just move the object somewhere LMAOOO
            deezNuts.transform.position = new Vector3(-22, -1, 0);

            //deezNuts.GetComponent<BoxCollider2D>().isTrigger = false;
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
