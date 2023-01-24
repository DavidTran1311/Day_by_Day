using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{

    public GameObject p;
    SpriteRenderer sr;
    public bool off;
    public BoxCollider2D bc;
    float cooldown;
    bool cdstart;
    public float cooldowntime;
    bool cdavail;

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

        if (cdstart == true)
        {

            cooldown = cooldown + Time.deltaTime;
            if (cooldown > cooldowntime)
            {
                cdstart = false;
                cooldown = 0;
            }

        }


    }

    private void FixedUpdate()
    {
        
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (Input.GetKey(KeyCode.E) && col.tag == "Player")
        {

            Debug.Log(cooldown);

            if (cooldown == 0)
            {

                cdstart = true;

                //if getting on ladder
                //else getting off
                p.transform.position = transform.position;
                if (off == true)
                {
                    off = false;
                    sr.color = Color.red;
                    bc.offset = new Vector2(-0.06f, -1.4f);

                }
                else
                {
                    off = true;
                    sr.color = Color.blue;
                    bc.offset = new Vector2(-0.06f, 1f);

                }

            }

        }

    }
}
