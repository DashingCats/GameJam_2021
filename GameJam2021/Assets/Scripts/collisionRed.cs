using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionRed : MonoBehaviour
{
    public GameObject player;

    void OnCollisionEnter(Collision collision)
    {
        print("HI");
    }
}
