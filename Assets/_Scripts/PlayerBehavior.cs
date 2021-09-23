using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float movementForce; // pulls value from unity
    public Rigidbody rigidBody; // pulls from unity

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>(); // Searches the game object for a rigidbody Done at Runtime
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            //move to the right
            rigidBody.AddForce(Vector3.right * movementForce);
        }
        if( Input.GetAxisRaw("Horizontal") < 0)
        {
            //move left
            rigidBody.AddForce(Vector3.left * movementForce);
        }
    }
}
