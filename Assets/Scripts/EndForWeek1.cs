using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndForWeek1 : MonoBehaviour
{
    public string Apartment;
    public string Menu;

    public GameObject gameOverPanel;
    public GameObject summaryBG;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
        summaryBG.SetActive(true);
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        SwitchToWeek2();
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

    public void SwitchToWeek2()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("ApartmentWeekTwo");

            //Debug.Log("press");
        }
    }
}