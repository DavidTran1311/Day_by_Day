using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallUI : MonoBehaviour
{
    public TMPro.TextMeshProUGUI t;
    public Balancemeter bm;

    // Start is called before the first frame update
    void Start()
    {

        t = GetComponent<TMPro.TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {

        t.text = "Falls: " + bm.fallCount;


    }
}
