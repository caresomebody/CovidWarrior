using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour{

    public int playerSpeed = 10;
    public bool facingRight = true;
    public int playeJumpPower =1250;
    public float moveX;

    public Animator animator;


    // Update is called once per frame
    void Update(){
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        playerMove();
    }

    void playerMove(){
        //controlst
        moveX= Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump")){
            Jump();
        }
        //animations
        //player direction
        if (moveX < 0.0f && facingRight==false){
            FlipPlayer();
        }
        else if (moveX > 0.0f && facingRight == true){
            FlipPlayer();
        }
        //physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("vaksin")){
            Destroy(other.gameObject);
        }
    }

    void Jump(){
        GetComponent<Rigidbody2D>().AddForce (Vector2.up * playeJumpPower);

    }

    void FlipPlayer(){

    }
}
