using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDay : MonoBehaviour
{
    public string endScreen;
    public string endScreenWeek2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            EndScreen();
        }
    }

    public void EndScreen()
    {
        SceneManager.LoadScene(endScreenWeek2);
    }
}
