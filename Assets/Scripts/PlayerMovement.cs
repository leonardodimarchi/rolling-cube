using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rigidBody;

    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

    void FixedUpdate() 
    {
        MoveUser();
    }


    void MoveUser()
    {
        MoveForward();
        MoveSidewaysAccordinglyToInput();

        if (rigidBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    void MoveForward()
    {
        rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);
    }

    void MoveSidewaysAccordinglyToInput()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
