using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSFX : MonoBehaviour
{
    public AudioSource footsies;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            footsies.enabled = true;
        }
        else
        {
            footsies.enabled = false;
        }

        if (Dialogue_Manager.GetInstance().DialogueIsPlaying)
        {
            footsies.enabled = false;
        }
        else
        {
            footsies.enabled = true;
        }

        if (Time.timeScale == 0f)
        {
            footsies.enabled = false;
        }
        else
        {
            return;
        }
    }
}
