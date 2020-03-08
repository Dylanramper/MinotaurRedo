using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D bc;
    Animator anim;

    public bool grounded;
    public bool sliding;
    public bool attacking;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();

        grounded = true;
        sliding = false;
        attacking = false;
    }

    // Update is called once per frame
    void Update()
    {
        Controls();

        //set the normal size of the box collider if player is not sliding
        if(sliding == false)
        {
            bc.size = new Vector2(bc.size.x, 0.36f);
            bc.offset = new Vector2(bc.offset.x, -0.03f);
        }
    }

    void Controls()
    {
        //Jump
        if (Input.GetKeyDown(KeyCode.W) && grounded == true && sliding == false && attacking == false)
        {
            rb.AddForce(new Vector2(0, 1500f));

            grounded = false;
            anim.SetBool("OnGround", false);
        }

        //Attack
        if(Input.GetKeyDown(KeyCode.Space) && grounded == true && sliding == false && attacking == false)
        {
            Debug.Log("Attacking");

            attacking = true;
            anim.SetBool("IsAttacking", true);
        }

        //Slide
        if (Input.GetKeyDown(KeyCode.S) && sliding == false && grounded == true && attacking == false)
        {
            //Set the box collider size to 0.2f and play the slide animation
            bc.size = new Vector2(bc.size.x, 0.25f);
            bc.offset = new Vector2(bc.offset.x, 0f);

            sliding = true;
            anim.SetBool("IsSliding", true);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Set grounded to true if player is on the gorund and stop the jump animation
        if(collision.gameObject.tag == "Ground")
        {
            grounded = true;
            anim.SetBool("OnGround", true);
        }
    }

    //reset the box collider size and stop the slide animation
    void ResetSlide()
    {
        sliding = false;
        anim.SetBool("IsSliding", false);
    }

    void ResetAttack()
    {
        attacking = false;
        anim.SetBool("IsAttacking", false);
    }
}
