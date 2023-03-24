using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IllustrationPopups : MonoBehaviour
{
    [SerializeField] private GameObject illustration;
    //[0Serializefield] private Image
    // Start is called before the first frame update
    void Start()
    {
        illustration.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        illustration.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        illustration.SetActive(false);
    }

}
