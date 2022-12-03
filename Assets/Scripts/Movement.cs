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
    public float lastFrameVelocityY = 0f;
    public float lastFrameVelocityYStored = 0f;
    public float direction;
    public float VelocityYtoVelocityXTimer = 0f;

    Vector2 playerMovement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        //Debug.Log("Velocity: " + rb.velocity.y);
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            direction = 1f;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            direction = -1f;
        }

        if (Mathf.Abs(rb.velocity.x) <= 20)
        {
            playerMovement.x = Input.GetAxisRaw("Horizontal") * playerMovementSpeed * Time.deltaTime;
            rb.AddForce(Vector2.right * playerMovement, ForceMode2D.Impulse);
            //Debug.Log(playerMovement);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Debug.Log("Jumped");
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

            if (VelocityYtoVelocityXTimer > 0f)
            {
                Debug.Log("WORKED JUMPED");
                rb.AddForce(Vector2.right * Mathf.Abs(lastFrameVelocityYStored) * direction * 1f, ForceMode2D.Impulse);
            }
        }

        if (rb.velocity.y > -1)
        {
            rb.gravityScale = gravityScale;
        }
        else
        {
            rb.gravityScale = fallGravityScale;
        }

        if (isGrounded && -lastFrameVelocityY > 10)
        {
            Debug.Log("WORKED");
            VelocityYtoVelocityXTimer = 0.5f;
            lastFrameVelocityYStored = lastFrameVelocityY;
}
        lastFrameVelocityY = rb.velocity.y;
        VelocityYtoVelocityXTimer -= Time.deltaTime;
    }

}
