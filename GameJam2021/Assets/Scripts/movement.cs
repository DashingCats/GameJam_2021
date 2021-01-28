using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float speed;
    public GameObject player;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if ((Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            Vector3 position = player.transform.position;
            position.x -= 0.05f * speed;
            player.transform.position = position;
        }
        if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            Vector3 position = player.transform.position;
            position.x += 0.05f * speed;
            player.transform.position = position;
        }
        if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.UpArrow)))
        {
            Vector3 position = player.transform.position;
            position.y += 0.05f * speed;
            player.transform.position = position;
        }
        if ((Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.DownArrow)))
        {
            Vector3 position = player.transform.position;
            position.y -= 0.05f * speed;
            player.transform.position = position;
        }

    }
}
