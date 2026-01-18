using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float runSpeed = 5f;

    Rigidbody2D rb;
    bool gravityDown = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        rb.linearVelocity = new Vector2(runSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FlipGravity();
        }
    }

    void FlipGravity()
    {
        gravityDown = !gravityDown;

        rb.gravityScale *= -1;

        
        Vector3 scale = transform.localScale;
        scale.y *= -1;
        transform.localScale = scale;
    }
}
