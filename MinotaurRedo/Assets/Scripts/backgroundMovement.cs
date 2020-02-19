using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMovement : MonoBehaviour
{
    //[SerializeField] GameObject backGround;
    [SerializeField] private float moveSpeed = 0f;
    private float posX = 18.44f;
    private float bound = -19.96f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveBackground();
    }

    void moveBackground()
    {
        transform.Translate(moveSpeed, 0, 0);
        if(transform.position.x <= bound)
        {
            transform.position = (new Vector2(posX, 0));
        }
    }
    
}