using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public string Apartment;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(Apartment);
    }

    public void StartGame()
    {
        
        animator.SetTrigger("StartGameFade");
        //OnFadeComplete();
    }

    public void QuitGame()
    {
        Application.Quit();

        Debug.Log("Quit");
    }

}
