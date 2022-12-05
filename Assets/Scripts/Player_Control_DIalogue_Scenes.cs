using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control_DIalogue_Scenes : MonoBehaviour
{
    private float horizontal;
    private float Vertical;
    Vector2 Movement;
    private float speed = 8f;
    [SerializeField] private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Dialogue_Manager.GetInstance().DialogueIsPlaying)
        {
            return;
        }


        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");


    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + Movement * speed * Time.fixedDeltaTime);
    }


}