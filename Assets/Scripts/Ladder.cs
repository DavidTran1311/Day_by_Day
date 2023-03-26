using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{

    public GameObject p;
    SpriteRenderer sr;
    public bool off;
    public bool fall;
    public BoxCollider2D bc;
    float cooldown;
    bool cdstart;
    public float cooldowntime;
    public GameObject meter;
    GameObject cm;
    bool cdavail;
    public PlayerControl pc;
    public Vector2 meterPos;
    public Balancemeter bm;
    public GameObject needle;

    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue, visualE;
    private bool PlayerInRange;

    // Start is called before the first frame update
    void Start()
    {

        sr = p.GetComponent<SpriteRenderer>();
        off = true;
        cdstart = false;
        cooldown = 0;

    }

    // Update is called once per frame
    void Update()
    {
        meterPos = new Vector2(p.transform.position.x, p.transform.position.y + 1);
       // Debug.Log(meterPos.x);

        if (cdstart == true)
        {

            cooldown = cooldown + Time.deltaTime;
            if (cooldown > cooldowntime)
            {
                cdstart = false;
                cooldown = 0;
            }

        }

        if (off == false)
        {
            meter.transform.position = meterPos;
        }


        if (bm.fall)
        {
            p.transform.position = new Vector2(-1,-3);
            bc.offset = new Vector2(-0.06f, 1f);
            fall = true;
            //sr.color = Color.blue;
            
            meter.transform.position = new Vector2(-100, 100);
            off = true;
            Debug.Log("collidercheck");
            //pc.goal = 0;
            if (pc.topped == true)
            {
                pc.topped = false;
            }
            bm.fall = false;
            bm.strike = 0;
        }

        //this is to make the trigger UI show
        if (PlayerInRange == true)
        {
            visualE.SetActive(true);
            visualCue.SetActive(true);
        }
        else
        {
            visualE.SetActive(false);
            visualCue.SetActive(false);
        }

    }

    private void FixedUpdate()
    {
        
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (Input.GetKey(KeyCode.E) && col.tag == "Player")
        {

            if (cooldown == 0)
            {

                cdstart = true;
                p.transform.position = transform.position;
                


                //if getting on ladder
                //else getting off
                if (off == true)
                {
                    off = false;
                    //sr.color = Color.red;
                    bc.offset = new Vector2(-0.06f, -1.4f);
                    meter.transform.position = meterPos;
                    needle.transform.position = new Vector2(meter.transform.position.x, needle.transform.position.y);
                    

                }
                else
                {
                    
                    //sr.color = Color.blue;
                    bc.offset = new Vector2(-0.06f, 1f);
                    meter.transform.position = new Vector2(-100,100);
                    off = true;
                    
                    if (pc.topped == true)
                    {
                        pc.topped = false;
                    }

                }

            }

        }

    }

    //this is for showing the trigger UI so the player knows what to press

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInRange = false;
        }
    }
}
