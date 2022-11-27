using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public GameObject player;
    private Movement MovementScript;
    private void Start()
    {
        MovementScript = player.GetComponent<Movement>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        MovementScript.isGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        MovementScript.isGrounded = false;
    }
}
