using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public string Apartment, TW;

    public Animator animator;

    [SerializeField] private GameObject twPanel;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        twPanel.SetActive(false);
    }

    public void OnFadeTW()
    {
        Debug.Log("TW Showing");
        twPanel.SetActive(true);
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
        
        animator.SetTrigger("TriggerWarningScreen");
        //OnFadeComplete();
    }

    public void QuitGame()
    {
        Application.Quit();

        Debug.Log("Quit");
    }

}
