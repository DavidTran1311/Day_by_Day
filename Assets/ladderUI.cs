using UnityEngine;
using UnityEngine.UI;

public class ladderUI : MonoBehaviour
{

    public TMPro.TextMeshProUGUI t;
    public PlayerControl p;

    // Start is called before the first frame update
    void Start()
    {

        t = GetComponent<TMPro.TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {

        t.text = "Boxes Stocked: " + p.goal;


    }
}
