using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMovement : MonoBehaviour
{
    public float moveSpeed = 0f;
    private float posX = 18.40f;
    private float bound = -19.96f;
    
    void Update()
    {
        moveBackground();
    }

    //If the image is too far to the left, spawn it to the right
    void moveBackground()
    {
        transform.Translate(moveSpeed, 0, 0);
        if(transform.position.x <= bound)
        {
            transform.position = (new Vector2(posX, 0));
        }
    }
}