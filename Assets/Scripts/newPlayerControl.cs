using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newPlayerControl : MonoBehaviour
{

    Vector2 Movement;
    private float speed = 3f;
    [SerializeField] private Rigidbody2D rb;
    public Animator anim;
    bool stationaryX;
    bool stationaryY;
    public GameObject eNews;
    public GameObject eDoor;
    public GameObject eNPC;
    public GameObject eAlex;
    bool paused;



    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("isLadder", false);



    }

    // Update is called once per frame
    void Update()
    {

        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");
        anim.SetFloat("Hor", Movement.x);
        anim.SetFloat("Vert", Movement.y);
        anim.SetBool("stationaryX", stationaryX);
        anim.SetBool("stationaryY", stationaryY);
        anim.SetBool("Paused", paused);




        if (Movement.x > 0 && Time.timeScale != 0 && paused == false)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            eNews.transform.localScale = new Vector3(-1, 1, 1);
            eDoor.transform.localScale = new Vector3(-1, 1, 1);
            eNPC.transform.localScale = new Vector3(-1, 1, 1);
            eAlex.transform.localScale = new Vector3(-1, 1, 1);

        }
        else if (Movement.x < 0 && Time.timeScale != 0 && paused == false)
        {
            transform.localScale = new Vector3(1, 1, 1);
            eNews.transform.localScale = new Vector3(1, 1, 1);
            eDoor.transform.localScale = new Vector3(1, 1, 1);
            eNPC.transform.localScale = new Vector3(1, 1, 1);
            eAlex.transform.localScale = new Vector3(1, 1, 1);
        }


        if (Dialogue_Manager.GetInstance().DialogueIsPlaying)
        {
            Time.timeScale = 1f;
            stationaryX = true;
            stationaryY = true;
            anim.enabled = false;
            paused = true;
            return;
        }
        else
        {

            anim.enabled = true;
            paused = false;

            if (Movement.x != 0)
            {
                rb.MovePosition(new Vector2(rb.position.x + Movement.x * speed * Time.deltaTime, rb.position.y));
                stationaryX = false;
                Debug.Log("true");

            }
            else
            {
                stationaryX = true;
            }

            if (Movement.y != 0)
            {
                rb.MovePosition(new Vector2(rb.position.x, rb.position.y + Movement.y * speed * Time.deltaTime));
                stationaryY = false;
            }
            else
            {
                stationaryY = true;
            }
        }





    }
}
