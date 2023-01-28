using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PlayerController : MonoBehaviour
{
    Vector2 Movement;
    public float speed = 3f;
    [SerializeField] private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        //MainMenuUI.instance.FadeFromBlack();
    }

    // Update is called once per frame
    void Update()
    {



        Movement.x = Input.GetAxisRaw("Horizontal");
            Movement.y = Input.GetAxisRaw("Vertical");


        if (Dialogue_Manager.GetInstance().DialogueIsPlaying)
        {
            Time.timeScale = 1f;
            return;
        }
        else
        {
            if (Movement.x != 0)
            {
                rb.MovePosition(new Vector2(rb.position.x + Movement.x * speed * Time.deltaTime, rb.position.y));
            }


            if (Movement.y != 0)
            {
                rb.MovePosition(new Vector2(rb.position.x, rb.position.y + Movement.y * speed * Time.deltaTime));

            }
        }




    }

    void FixedUpdate()
    {

        

    }

 
}
