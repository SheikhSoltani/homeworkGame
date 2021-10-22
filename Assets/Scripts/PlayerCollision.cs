using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;


    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        if (collisionInfo.collider.tag == "jump")
        {
            Debug.Log("jump");
            //movement.sidewayForce * Time.deltaTime
            movement.rb.AddForce(0, movement.jumpForce, -80, ForceMode.Impulse);
        }
        if (collisionInfo.collider.tag == "back")
        {
            Debug.Log("back");
            //
            movement.rb.AddForce(0, 0, -85, ForceMode.Impulse);
        }
        if (collisionInfo.collider.tag == "stay")
        {
            Debug.Log("stay");
            //
            movement.rb.AddForce(0, 0, -85, ForceMode.Impulse);
        }
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "back")
        {
            Debug.Log("back");
            //
            movement.rb.AddForce(0, 0, -1.9f * movement.forwardForce * Time.deltaTime);
        }
        if (collisionInfo.collider.tag == "stay")
        {
            Debug.Log("stay");
            //
            movement.rb.AddForce(0, 0, -1 * movement.forwardForce * Time.deltaTime);
        }
    }



}
