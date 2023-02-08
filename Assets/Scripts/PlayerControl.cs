using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    Vector2 Movement;
    private float speed = 3f;
    [SerializeField] private Rigidbody2D rb;
    public GameObject ladder;
    public Ladder lad;
    public Animator anim;
    public int goal;
    public bool topped = false;
    public GameObject UI;

    float cooldown;
    bool cdstart;
    float cooldowntime = 0.5f;

    bool carrying;
    public GameObject pickup;

    // Start is called before the first frame update
    void Start()
    {
        UI.SetActive(false);
        cdstart = false;

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


        if (lad.off)
        {

            anim.SetBool("isLadder", false);
            //UI.SetActive(false);

            if (Dialogue_Manager.GetInstance().DialogueIsPlaying)
            {
                Time.timeScale = 1f;
                return;
            }

            if (Movement.x != 0)
            {
                rb.MovePosition(new Vector2(rb.position.x + Movement.x * speed * Time.deltaTime, rb.position.y));
            }


            if (Movement.y != 0)
            {
                rb.MovePosition(new Vector2(rb.position.x, rb.position.y + Movement.y * speed * Time.deltaTime));
            }

        } else
        {

            anim.SetBool("isLadder", true);
            UI.SetActive(true);

            if (Movement.y != 0)
            {
                rb.MovePosition(new Vector2(rb.position.x, rb.position.y + Movement.y * speed/3 * Time.deltaTime));

            }
        }




        if (cdstart == true)
        {

            cooldown = cooldown + Time.deltaTime;
            if (cooldown > cooldowntime)
            {
                cdstart = false;
                cooldown = 0;
            }

        }

        if (carrying == true)
        {
            pickup.transform.position = transform.position;
        }



    }

    private void FixedUpdate()
    {

        

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "Goal")
        {
            if (topped == false)
            {
                topped = true;
                goal += 1;
            }
            
        }


    }


    private void OnTriggerStay2D(Collider2D other)
    {
        
        if (other.tag == "Carryable" && Input.GetKey(KeyCode.Space))
        {


            if (cdstart == false)
            {
                cdstart = true;

                if (carrying == false)
                {
                    carrying = true;
                    Debug.Log(carrying);

                }

                else if (carrying == true)
                {
                    carrying = false;
                }


                



                
            }

            if (other.tag == "EPlace" && Input.GetKey(KeyCode.Space))
            {


                if (cdstart == false)
                {
                    cdstart = true;

                    if (carrying == false)
                    {
                        carrying = true;
                        Debug.Log(carrying);

                    }

                    else if (carrying == true)
                    {
                        carrying = false;
                    }







                }




            }




        }


    }
}