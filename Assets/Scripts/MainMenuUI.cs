using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public string Apartment, TW;

    public Animator animator;

    public bool clickedIt;

    [SerializeField] private GameObject twPanel; 
    //[SerializeField] private GameObject StartUI;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        twPanel.SetActive(false);
        //StartUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        DudeIClickedIt();
    }

    public void OnFadeTW()
    {
        Debug.Log("TW Showing");
        //twPanel.SetActive(true);
    }

    public void OnFadeToTW()
    {
        SceneManager.LoadScene(TW);
    }
    
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(Apartment);
    }

    public void StartGame()
    {
        Debug.Log("CLICKED");
        clickedIt = true;

        //OnFadeComplete();
    }

    public void FadeToBlack()
    {

            animator.SetTrigger("FadeFromBlack");
    }

    public void SpacePressed()
    {
        if (Input.GetKey(KeyCode.E))
        {
            FadeToBlack();
        }
    }

    public void QuitGame()
    {
        Application.Quit();

        Debug.Log("Quit");
    }

    public void DudeIClickedIt()
    {
        if(clickedIt == true)
        {
            twPanel.SetActive(true);
            animator.SetTrigger("StartGameFade");
        }
    }
}
