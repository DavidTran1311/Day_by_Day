using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balancemeter : MonoBehaviour
{


    float initialX;
    public float bForce;
    public Rigidbody2D rb;
    public BoxCollider2D leftCol;
    public BoxCollider2D rightCol;
    public GameObject met;
    public int strike;
    public bool fall;
    public int fallCount;
    public Ladder lad;

    // Start is called before the first frame update
    void Start()
    {

        fall = false;

    }

    // Update is called once per frame
    void Update()
    {

        initialX = met.transform.position.x;
        //Debug.Log(initialX);

        if (lad.off == false)
        {

            if (transform.position.x > initialX)
            {

                rb.AddForce(new Vector2(bForce / 5, 0), ForceMode2D.Force);

            }
            else
            {

                rb.AddForce(new Vector2(-bForce / 5, 0), ForceMode2D.Force);

            }

            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(new Vector2(bForce / 2.5f, 0), ForceMode2D.Force);
                //Debug.Log("Right");
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(new Vector2(-bForce / 2.5f, 0), ForceMode2D.Force);
                //Debug.Log("Left");
            }
        }

    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Strike")
        {
            transform.position = new Vector2(initialX, transform.position.y);

            strike = strike +1;

            if (strike >= 3)
            {
                fall = true;
                fallCount += 1;
            }

        }
    }
}
