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


        if (lad.off)
        {

            anim.SetBool("isLadder", false);

            if (Dialogue_Manager.GetInstance().DialogueIsPlaying)
            {
                Time.timeScale = 1f;
                return;
            }

            if (Movement.x != 0)
            {
                rb.MovePosition(new Vector2(rb.position.x + Movement.x * speed * Time.deltaTime, rb.position.y));
                Debug.Log("horizontal");
            }


            if (Movement.y != 0)
            {
                rb.MovePosition(new Vector2(rb.position.x, rb.position.y + Movement.y * speed * Time.deltaTime));
                Debug.Log("vertical");
            }

        } else
        {

            anim.SetBool("isLadder", true);

            if (Movement.y != 0)
            {
                rb.MovePosition(new Vector2(rb.position.x, rb.position.y + Movement.y * speed/3 * Time.deltaTime));

            }
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
}