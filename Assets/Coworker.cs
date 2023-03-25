using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coworker : MonoBehaviour
{

    public bool box;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        anim.SetBool("box", box);

    }
}
