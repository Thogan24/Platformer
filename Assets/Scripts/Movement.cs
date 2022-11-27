using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Objects")]
    public GameObject GroundCheck;
    public Rigidbody2D rb;

    [Header ("Movement Variables")]
    [SerializeField] float jumpForce = 10;
    [SerializeField] float gravityScale = 5;
    [SerializeField] float fallGravityScale = 1;
    [SerializeField] float playerMovementSpeed = 1f;
    public bool isGrounded = false;

    Vector2 playerMovement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        Debug.Log(rb.velocity.magnitude);
        playerMovement.x = Input.GetAxisRaw("Horizontal") * playerMovementSpeed * Time.deltaTime;

        rb.AddForce(Vector2.right * playerMovement, ForceMode2D.Impulse);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log("ran");
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        //if (GroundCheck.GetComponent<Collider2D>().)
        {
            Debug.Log("Yeah");
        }
        /*if (rb.velocity.y > 0)
        {
            rb.gravityScale = gravityScale;
        }
        else
        {
            rb.gravityScale = fallGravityScale;
        }*/
    }

}
