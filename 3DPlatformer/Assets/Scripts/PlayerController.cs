using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    private Rigidbody rig;

    void Awake() 
    {
        //get the rigidbody component
        rig = GetComponent<Rigidbody>();    
    }

    void Update() 
    {
        Move(); 

        // did we press down the "jump" button?
        if(Input.GetButtonDown("Jump"))
        {
            TryJump();
        }           
    }
    void Move ()
    {
        //getting our inputs
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // calculate the direction we need to move in
        Vector3 dir = new Vector3(xInput, 0, zInput) * moveSpeed;
        dir.y = rig.velocity.y;

        // set the rigidbody velocity
        rig.velocity = dir;

        // calculate the new forward direction
        Vector3 facingDir = new Vector3(xInput, 0, zInput);

        // are we holding down our movement buttons?
        if(facingDir.magnitude > 0)
        {
            transform.forward = facingDir;
        }
    }
    // called when we press the "jump" button
    void TryJump ()
    {
        // create ray pointing downwards from the player
        Ray ray = new Ray(transform.position, Vector3.down);

        if(Physics.Raycast(ray, 0.7f))
        {
            // add force upwards
            rig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
