using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChecklistZoom : MonoBehaviour
{
    public Animator anim;
    public bool checklistClosed = true;
    public bool checklistOpened = false;

    void Update()
    {

    }

    public void OpenChecklist()
    {

        if (checklistClosed == true)
        {
            anim.SetTrigger("HoverTriggerEnter");
        }
        else if (checklistOpened == true)
        {
            anim.ResetTrigger("HoverTriggerEnter");
        }


    }


    public void OpenTrue()
    {
        checklistOpened = true;
        checklistClosed = false;
    }

    public void CloseTrue()
    {
        checklistClosed = true;
        checklistOpened = false;
    }
}

