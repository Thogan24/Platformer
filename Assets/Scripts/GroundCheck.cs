using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public GameObject player;
    private Movement MovementScript;
    private void Start()
    {
        MovementScript = player.GetComponent<Movement>();
    }
    // Because there are multiple triggers getting entered
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 6)
            MovementScript.isGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        MovementScript.isGrounded = false;
    }
}
