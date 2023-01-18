using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control_DIalogue_Scenes : MonoBehaviour
{

    Vector2 Movement;
    private float speed = 20f;
    [SerializeField] private Rigidbody2D rb;
    public GameObject ladder;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        /*
        if (Dialogue_Manager.GetInstance().DialogueIsPlaying)
        {
            return;
        }
        */


        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");

        if (Movement.x != 0)
        {
            rb.MovePosition(new Vector2(rb.position.x + Movement.x * speed * Time.deltaTime, rb.position.y));
        }


        if (Movement.y != 0)
        {
            rb.MovePosition(new Vector2(rb.position.x, rb.position.y + Movement.y * speed * Time.deltaTime));

        }


    }

    private void FixedUpdate()
    {

        

    }
}