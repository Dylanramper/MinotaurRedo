using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    Rigidbody2D rb;
    BoxCollider2D bc;
    Animator anim;

    public GameObject Wolf;

    bool grounded;
    bool sliding;
    public bool attacking;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();

        grounded = true;
        sliding = false;
        attacking = false;
    }
    
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

        //if player collides with an enemy, kill the player
        if(collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Wolf")
        {
            anim.SetBool("IsDead", true);
        }

        if(collision.gameObject.tag == "Wolf" && attacking)
        {
            Debug.Log("Wolf should be dead");
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

    void KillPlayer()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
}
