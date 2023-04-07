using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScreenWeek2 : MonoBehaviour
{

    public GameObject summaryBG;
    public Animator animator;

    public void Start()
    {
        summaryBG.SetActive(true);
        Cursor.visible = true;
    }

    public void Update()
    {
        GameOverScreen();
    }

    public void FadeToLevel()
    {
        animator.SetTrigger("FadeToBlack");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();

        Debug.Log("Quit");
    }

    public void GameOverScreen()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("ApartmentWeekThree");
            summaryBG.SetActive(false);
            //Debug.Log("press");
        }
    }
}
