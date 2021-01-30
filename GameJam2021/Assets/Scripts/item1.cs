using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item1 : MonoBehaviour
{
    public GameObject red;
    Collider2D m_collider;

    // Start is called before the first frame update
    void Start()
    {
        m_collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if((red.transform.position.x <=-1) && (red.transform.position.y >= 2))
        {
            red.transform.position = new Vector3(-1, 3, 1);
            m_collider.enabled = false;
            
        }
        
    }
}
