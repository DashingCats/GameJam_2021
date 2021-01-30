using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostChase : MonoBehaviour
{

    public GameObject player;
    public GameObject ghost;
    public float speedOfGhost = 4;
    private int maxDist = 10;
    private int minDist = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        if (Vector2.Distance(transform.position, player.transform.position) >= minDist) 
        {
            transform.position += transform.forward * speedOfGhost * Time.deltaTime;
        
        }
        if (Vector2.Distance(transform.position, player.transform.position) <= maxDist) 
        {
            
            transform.position += transform.forward * speedOfGhost * Time.deltaTime;
        }
    }
}
