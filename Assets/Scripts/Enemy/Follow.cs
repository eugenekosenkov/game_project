using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

    public Enemy enemy;

    private Transform target;

    private bool looksRight = true;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (transform.position.x < target.position.x && looksRight)
        {
            looksRight = !looksRight;
            transform.Rotate(0f, 180f, 0f);
        }
        else if (transform.position.x > target.position.x && !looksRight)
        {
            looksRight = !looksRight;
            transform.Rotate(0f, 180f, 0f);
        }
        if(Mathf.Abs(transform.position.x - target.position.x)< enemy.distationPlayer && Mathf.Abs(transform.position.y - target.position.y)< enemy.distationPlayer)
            transform.position = Vector2.MoveTowards(transform.position, target.position, enemy.speed*Time.deltaTime);
    }

}
