using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummaryScreen : MonoBehaviour
{
    public TMPro.TextMeshProUGUI pay;
    public TMPro.TextMeshProUGUI savings;
    public TMPro.TextMeshProUGUI rent;
    public TMPro.TextMeshProUGUI food;
    public TMPro.TextMeshProUGUI bills;
    public TMPro.TextMeshProUGUI insurance;
    public TMPro.TextMeshProUGUI total;
    public float m_rent;
    public float m_food;
    public float m_bills;
    public float m_insurance;
    public static float m_total;
    public static float scoreGUI;
    public static float savingsGUI;
    public static float m_savings;

    void Awake()
    {
        
        scoreGUI = PlayerControl.score * 47.5f + 100;
        scoreGUI = Mathf.Round(scoreGUI);
        
    }

    void Start()
    {

        Debug.Log(PlayerControl.score);

        if (savingsGUI == 0)
        {
            savingsGUI = 1226;
        }

        m_total = scoreGUI + savingsGUI + m_food + m_bills + m_rent + m_insurance;

        if (m_total > 0)
        {
            total.color = new Color32(28, 106, 27, 255);
        }

        pay.text = "$" + scoreGUI;
        savings.text = "$" + savingsGUI;
        rent.text = "$" + m_rent;
        food.text = "$" + m_food;
        bills.text = "$" + m_bills;
        insurance.text = "$" + m_insurance;
        total.text = "$" + m_total;

        m_savings = m_total;
    }

    void Update()
    {
        
    }
}
