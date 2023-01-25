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

    // Start is called before the first frame update
    void Start()
    {

        initialX = transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        

        if (transform.position.x > initialX)
        {

            rb.AddForce(new Vector2(bForce/100, 0), ForceMode2D.Force);

        } else
        {

            rb.AddForce(new Vector2(-bForce / 100, 0), ForceMode2D.Force);

        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(bForce / 50, 0), ForceMode2D.Force);
            Debug.Log("Right");
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-bForce / 50, 0), ForceMode2D.Force);
            Debug.Log("Left");
        }

    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Strike")
        {
            transform.position = new Vector2(initialX, transform.position.y);
        }
    }
}
