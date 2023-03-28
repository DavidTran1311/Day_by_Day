using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OtherUI : MonoBehaviour
{
    public string Apartment;
    public string Menu;

    public GameObject gameOverPanel;
    public GameObject summaryBG;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }
        if (summaryBG != null)
        {
            summaryBG.SetActive(true);
        }
        
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameOverScreen();
    }
   
    public void FadeToLevel()
    {
        animator.SetTrigger("FadeToBlack");
    }



    public void MainMenu()
    {
        SceneManager.LoadScene(Menu);
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
            if (summaryBG != null)
            {
                summaryBG.SetActive(false);
            }
            if (gameOverPanel != null)
            {
                gameOverPanel.SetActive(true);
            }
            

            //Debug.Log("press");
        }
    }
}
