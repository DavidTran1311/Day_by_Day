using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LilyChecklistTrigger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI tickChecklist;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            tickChecklist.text = "<s>- Talk to Lily about George before leaving</s>";
        }
    }
}
