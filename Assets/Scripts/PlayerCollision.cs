using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            playerMovement.enabled = false;
        }
    }
}
