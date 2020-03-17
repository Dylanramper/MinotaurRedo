using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float moveSpeed;
    
    void Start()
    {
        //set the enemy move speed
        moveSpeed = 0.04f;
    }
    
    void Update()
    {
        //move the enemy to the left and destroy them when they get past the player
        transform.Translate(-moveSpeed, 0f, 0f);

        if(transform.position.x <= -12f)
        {
            Destroy(gameObject);
        }
    }
}
