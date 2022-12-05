using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RoomSwap : MonoBehaviour
{
    void Start()
    {
        Debug.Log("LoadSceneA");
    }

    private void Update()
    {
       
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("something has entered my trigger");
        
        if (other.gameObject.tag == "Player")
        {
            LoadA();
        } 
    }

    public void LoadA()
    {
    SceneManager.LoadScene("Hospital");
    }

}
