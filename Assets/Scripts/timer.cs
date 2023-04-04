using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{

    public float totalTime;
    public float time;
    public PlayerControl pc;

    // Start is called before the first frame update
    void Start()
    {
        time = totalTime*60;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (pc.start == true && time >= 0)
        {
            time -= Time.deltaTime;
        }
        if (time <= 0)
        {
            pc.endtimer = true;
        }


    }
}
