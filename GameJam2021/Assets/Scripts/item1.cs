using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class item1 : MonoBehaviour
{
    public GameObject obj1;
    public GameObject loc1;
    Rigidbody2D m_rig1;
    Collider2D m_collider1;

    public Text mainText;
    private bool isSealed = false;

    // Start is called before the first frame update
    void Start()
    {
        m_collider1 = obj1.GetComponent<Collider2D>();
        m_rig1 = obj1.GetComponent<Rigidbody2D>();

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
    private void OnTriggerEnter2D(Collider2D colTrig1)
    {

        if (colTrig1.gameObject.name == "Stand1") 
        {
            Debug.Log("It has been placed");
            obj1.transform.position = loc1.transform.position;
            
            mainText.text = "It has been sealed";
            StartCoroutine(Countdown());
            isSealed = true;
            m_rig1.isKinematic = true;
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
        

    }
}
