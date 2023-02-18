using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PopUpQuestion : MonoBehaviour
{
    //these variables are for popup UI after the player falls
    [SerializeField] private GameObject popUpHospital;
    [SerializeField] private GameObject AreYouSureHospital;
    [SerializeField] private GameObject AreYouSureHome;

    // Start is called before the first frame update
    void Start()
    {
        popUpHospital.SetActive(false);
        AreYouSureHome.SetActive(false);
        AreYouSureHospital.SetActive(false);
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            MainPopUp();
        }
    }

    public void LoadHospital()
    {
        SceneManager.LoadScene("HospitalER");
        Time.timeScale = 1f;
    }

    public void LoadHome()
    {
        SceneManager.LoadScene("Apartment");
        Time.timeScale = 1f;
    }

    public void UncertainHospital()
    {
        AreYouSureHospital.SetActive(true);
        Time.timeScale = 0f;
    }

    public void UncertainHome()
    {
        AreYouSureHome.SetActive(true);
        Time.timeScale = 0f;
    }

    public void MainPopUp()
    {
        AreYouSureHospital.SetActive(false);
        AreYouSureHome.SetActive(false);
        popUpHospital.SetActive(true);
        Time.timeScale = 0f;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            MainPopUp();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            popUpHospital.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
