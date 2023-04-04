using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerUI : MonoBehaviour
{
    public timer timer;
    public TMPro.TextMeshProUGUI t;
    float displaytime;

    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {

        displaytime = Mathf.Round(timer.time);

        t.text = "Time: " + displaytime;
    }
}
