using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rigidBody;

    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

    void FixedUpdate() 
    {
        rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);

        this.moveUser();
    }


    void moveUser()
    {
        if (Input.GetKey("d"))
        {
            rigidBody.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rigidBody.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }
    }
}
