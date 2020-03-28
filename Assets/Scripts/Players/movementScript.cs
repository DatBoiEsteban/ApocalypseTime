using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{

    public float moveHorizontal;
    public float moveVertical;  
    public float speed;

    public Rigidbody2D player;
    private Vector2 movement;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*
         * Great explanation of AddForce vs Velocity 
         * */
        moveHorizontal = Input.GetAxis("Horizontal") * speed;
        moveVertical = Input.GetAxis("Vertical") * speed;

        movement = new Vector2(moveHorizontal, moveVertical);
       
        //Uncomment and play around with the options below for Add Force for better understanding
        //player.AddForce(movement * speed); //think Rocket thruster
        //player.AddForce(movement * speed, ForceMode2D.Force);
        //player.AddForce(movement * speed, ForceMode2D.Impulse);
        player.velocity = movement * speed; //think regular movement, similar to the Transform.translate example
    }
}
