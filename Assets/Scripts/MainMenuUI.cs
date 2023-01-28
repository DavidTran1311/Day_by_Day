using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public string Apartment;
    public string Menu;

    public Image fadeScreen;
    public GameObject fadePanel;
    public float fadeSpeed;
    public bool shouldFadeToBlack, shouldFadeFromBlack;
    public GameObject gameOverPanel;
    public GameObject summaryBG;

    public static MainMenuUI instance;


    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
        summaryBG.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldFadeToBlack)
        {
            fadeScreen.color = new Color(fadeScreen.color.r, fadeScreen.color.g, fadeScreen.color.b, Mathf.MoveTowards(fadeScreen.color.a, 1f, fadeSpeed * Time.deltaTime));
            if(fadeScreen.color.a == 1f)
            {
                shouldFadeToBlack = false;
            }
        }

        if (shouldFadeFromBlack)
        {
            fadeScreen.color = new Color(fadeScreen.color.r, fadeScreen.color.g, fadeScreen.color.b, Mathf.MoveTowards(fadeScreen.color.a, 0f, fadeSpeed * Time.deltaTime));
            if (fadeScreen.color.a == 0f)
            {
                shouldFadeFromBlack = false;
            }
        }

        GameOverScreen();
    }

    public void FadeToBlack()
    {
        shouldFadeToBlack = true;
        shouldFadeFromBlack = false;

        Instantiate(fadePanel, new Vector3(2.0f, 0, 0), Quaternion.identity);
        Destroy(fadePanel);
    }

    public void FadeFromBlack()
    {
        Instantiate(fadePanel, new Vector3(2.0f, 0, 0), Quaternion.identity);
        
        shouldFadeFromBlack = true;
        shouldFadeToBlack = false;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(Apartment);

        FadeToBlack();
        fadePanel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();

        Debug.Log("Quit");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(Menu);
    }

    public void GameOverScreen()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            summaryBG.SetActive(false);
            gameOverPanel.SetActive(true);

            //Debug.Log("press");
        }
    }
}
