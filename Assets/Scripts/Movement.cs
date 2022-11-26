using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector2 movement;
    [SerializeField] float jumpForce = 10;
    [SerializeField] float gravityScale = 5;
    [SerializeField] float fallGravityScale = 1;

    [SerializeField] Rigidbody2D rb;

    public float Speed = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");

        //rb.velocity.x = h * Speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
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
