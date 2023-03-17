using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomFading : MonoBehaviour
{
    public SpriteRenderer sr;
    [SerializeField] private bool fadeIn;
    [SerializeField] private bool fadeOut;
    public float fadeSpeed;


    void Start()
    {
     //sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

    }

    public IEnumerator FadeOutBlock()
    {
        while (sr.GetComponent<SpriteRenderer>().color.a > 0)
        {
            Color objectColor = sr.GetComponent<SpriteRenderer>().color;
            float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            sr.GetComponent<SpriteRenderer>().color = objectColor;
            yield return null;

            /*  if (objectColor.a <= 0)
              {
                  fadeOut = false;
              } */
        }
    }

    public IEnumerator FadeInBlock()
    {
        while (sr.GetComponent<SpriteRenderer>().color.a < 1)
        {
            Color objectColor = sr.GetComponent<SpriteRenderer>().color;
            float fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            sr.GetComponent<SpriteRenderer>().color = objectColor;
            yield return null;

        }
    }

     public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                //sr.enabled = false;
                StartCoroutine(FadeOutBlock());
            }
        }

     public void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                //sr.enabled = true;
                StartCoroutine(FadeInBlock());
            }
        }
    }

