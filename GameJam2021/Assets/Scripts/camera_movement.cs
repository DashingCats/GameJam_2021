using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{
    private Transform player; private Vector3 cameraPos;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        cameraPos = player.position - transform.position;
    }

    void Update()
    {
        if (player.localPosition.x < 46.0f && player.localPosition.x > -20.0f)
        {
            transform.position = player.position - cameraPos;
        }
    }
    }
