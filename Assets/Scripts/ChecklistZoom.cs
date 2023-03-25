using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChecklistZoom : MonoBehaviour
{
    public GameObject smallList;
    public GameObject bigList;
    public bool zoomedIn;

    void Start()
    {
        smallList.SetActive(true);
        bigList.SetActive(false);
        zoomedIn = false;
    }


    void Update()
    {
        zoom();
    }

    void zoom()
    {
        if (Input.GetKey(KeyCode.L) && zoomedIn == false)
        {
            smallList.SetActive(false);
            bigList.SetActive(true);
            zoomedIn = true;

        }

        if (Input.GetKey(KeyCode.L) && zoomedIn == true)
        {
            smallList.SetActive(true);
            bigList.SetActive(false);
            zoomedIn = false;
        }
    }

}

