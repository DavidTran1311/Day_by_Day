using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Savings : MonoBehaviour
{
    public static float savingsValue;
    public TMPro.TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        savingsValue = SummaryScreen.m_savings;

        if (savingsValue == 0)
        {
            text.text = "$" + 1226;
        } else
        {
            text.text = "$" + savingsValue;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
