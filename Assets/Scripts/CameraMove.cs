using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class CameraMove : MonoBehaviour
{
    public float speed;

    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;        
    }

    void Update()
    {
        if (player)
        {
            Vector3 target = new Vector3(player.position.x, player.position.y, transform.position.z); 


            Vector3 currentPosition = Vector3.Lerp(transform.position, target, speed * Time.deltaTime);

            transform.position = currentPosition;

        }
    }
}
