using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class item1 : MonoBehaviour
{
    public GameObject red;
    public GameObject stand;
    public Text mainText;

    Rigidbody2D m_rigi;
    Collider2D m_collider;

    private bool isSealed = false;

    // Start is called before the first frame update
    void Start()
    {
        m_collider = GetComponent<Collider2D>();
        m_rigi = GetComponent<Rigidbody2D>();
        mainText.text = "";
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        {
            if (isSealed == false)
            {
                mainText.text = "Lovely is not?";
                StartCoroutine(Countdown());

            }
            else 
            {
                mainText.text = "True beauty ,no?";
                StartCoroutine(Countdown());
            }
            
 
        }


    }
    private void OnTriggerEnter2D(Collider2D colTrig)
    {

        if (colTrig.gameObject.name == "Stand") 
        {
            Debug.Log("It has been placed");
            red.transform.position = stand.transform.position;
            
            mainText.text = "It has been sealed";
            StartCoroutine(Countdown());
            isSealed = true;
            m_rigi.isKinematic = true;

        }

    }

    //Begins Countdown for text to disappear
   private IEnumerator Countdown() 
    {
        float counter = 5;
        
        while (counter > 0)
        {

            yield return new WaitForSeconds (1);
            counter--;
        }
        mainText.text = "  ";

    
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if((red.transform.position.x <=-1) && (red.transform.position.y >= 2))
        {
            red.transform.position = new Vector3(-1, 3, 1);
            m_collider.enabled = false;
            
        }
        */

    }
}
