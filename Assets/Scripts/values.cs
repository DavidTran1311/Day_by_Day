using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class values : MonoBehaviour
{

    public Balancemeter needle;
    public int strike;
    public bool fall;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(strike);

        strike = needle.strike;
        fall = needle.fall;

    }
}
