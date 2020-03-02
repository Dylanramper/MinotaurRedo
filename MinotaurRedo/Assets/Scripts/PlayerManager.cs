using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D bc;

    public bool grounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();

        grounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        Controls();
    }

    void Controls()
    {
        //Jump
        if (Input.GetKeyDown(KeyCode.W) && grounded == true)
        {
            rb.AddForce(new Vector2(0, 1500f));

            grounded = false;
        }

        //Attack

        //Slide
        if (Input.GetKeyDown(KeyCode.S))
        {
            bc.size = new Vector2(bc.size.x, 0.2f);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Set grounded to true if player is on the gorund
        if(collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
}
