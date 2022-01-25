using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rigidBody;

    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

    void FixedUpdate() 
    {
        moveUser();
    }


    void moveUser()
    {
        moveForward();
        moveSidewaysAccordinglyToInput();
    }

    void moveForward()
    {
        rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);
    }

    void moveSidewaysAccordinglyToInput()
    {
        if (Input.GetKey("d"))
        {
            rigidBody.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rigidBody.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
