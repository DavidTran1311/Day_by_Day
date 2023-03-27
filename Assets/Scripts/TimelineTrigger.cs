using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineTrigger : MonoBehaviour
{

    private PlayableDirector dir;
    public GameObject trigger;
    public GameObject timeline;
    bool paused;
    public Animator anim;

    private void Awake()
    {
        dir = timeline.GetComponent<PlayableDirector>();
        dir.stopped += Director_Stopped;
        

    }

    private void Update()
    {
        anim.SetBool("Paused", paused);
    }
    private void Director_Stopped (PlayableDirector obj)
    {
        Time.timeScale = 1f;
        paused = false;
        if (trigger != null)
        {
            trigger.SetActive(false);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "trigger")
        {
            dir.Play();
            Time.timeScale = 0f;
            paused = true;

        }

    }
}
