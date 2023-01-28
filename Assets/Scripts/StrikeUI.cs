using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeUI : MonoBehaviour
{
    public TMPro.TextMeshProUGUI t;
    public Balancemeter bm;
    int strike;

    // Start is called before the first frame update
    void Start()
    {

        t = GetComponent<TMPro.TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {

        strike = bm.strike;
        //Debug.Log(strike);
        t.text = "Close Calls: " + strike;


    }
}
