using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RoomSwap : MonoBehaviour
{
    [SerializeField] private GameObject popUpUI;
    [SerializeField] private GameObject visualCue;
    [SerializeField] private GameObject visualE;
    public string LadderMinigame;
    public float inRange;

    void Start()
    {
        visualCue.SetActive(false);
        popUpUI.SetActive(false);
        visualE.SetActive(false);

        inRange = 0f;
    }

    private void Update()
    {
         if (Input.GetKeyDown(KeyCode.E) && inRange == 1f)
            {
                popUpUI.SetActive(true);
                Time.timeScale = 0f;
            }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            visualCue.SetActive(true);
            visualE.SetActive(true);
            inRange = 1f;
        } 
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            popUpUI.SetActive(false);
            visualCue.SetActive(false);
            visualE.SetActive(false);
            Time.timeScale = 1f;
            inRange = 0f;
        }
    }

    public void LoadLadderMinigame()
    {
    SceneManager.LoadScene("LadderMinigame");
        Time.timeScale = 1f;
    }

    public void DeactivateOverlay()
    {
        popUpUI.SetActive(false);
        Time.timeScale = 1f;
    }

}
