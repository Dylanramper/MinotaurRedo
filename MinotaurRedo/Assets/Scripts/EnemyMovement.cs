using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 0.04f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-moveSpeed, 0f, 0f);

        if(transform.position.x <= -12f)
        {
            Destroy(gameObject);
        }
    }
}
