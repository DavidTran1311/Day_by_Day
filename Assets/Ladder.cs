using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{

    public GameObject p;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {

        sr = p.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

        

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.tag == "Player")
        {
            sr.color = Color.red;
        }

    }
}
