using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineTrigger : MonoBehaviour
{

    private PlayableDirector dir;
    public GameObject trigger;
    public GameObject timeline;

    private void Awake()
    {
        dir = timeline.GetComponent<PlayableDirector>();
        dir.stopped += Director_Stopped;
    }

    private void Director_Stopped (PlayableDirector obj)
    {
        Time.timeScale = 1f;
        trigger.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "trigger")
        {
            dir.Play();
            Time.timeScale = 0f;
        }

    }
}
