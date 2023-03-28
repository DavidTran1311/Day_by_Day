using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScreenWeek2 : MonoBehaviour
{
    public string Apartment;
    public string MainMenu;

    public GameObject gameOverPanel;
    public GameObject summaryBG;
    public Animator animator;

    public void Start()
    {
        gameOverPanel.SetActive(false);
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
            gameOverPanel.SetActive(true);
            summaryBG.SetActive(false);
            //Debug.Log("press");
        }
    }
}
