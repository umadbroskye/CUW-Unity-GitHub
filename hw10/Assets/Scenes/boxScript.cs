using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour{
    public float speed = 5.0f;
    public float jumpAmount = 10.0f;
    private Rigidbody rb;

    void Start(){
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    void Update(){
        Transform cTransform = Camera.main.transform; //get camera transform
        Vector3 fMovement = cTransform.forward * Input.GetAxis("Vertical"); //set forward movement to what is "forward" according to the camera (if the cube flips, this script will still work)
        Vector3 hMovement = cTransform.right * Input.GetAxis("Horizontal"); //similar to the above except with a different axis. Move relative to the camera, ignore position/rotation of the cube
        Vector3 movement = Vector3.ClampMagnitude(fMovement + hMovement, 1); //clamp magnitute of fmovement + hmovement to 1
        transform.Translate(movement * speed * Time.deltaTime, Space.World); //moves the cube

        if (Input.GetKeyDown("space")){ //check if space is pressed
            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse); //adds an impulse force to the cube, this gives it a better jump
        }
    }
    void FixedUpdate(){
        rb.AddForce(Physics.gravity * 2 * rb.mass); //proper jumps (making sure the cube falls down at a nice speed instead of floating/hanging in the air)
    }
}