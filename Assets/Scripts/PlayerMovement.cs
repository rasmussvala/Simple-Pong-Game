using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public string inputAxis = "Vertical";
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // move body
        float movement = Input.GetAxis(inputAxis);
        rb.linearVelocity = new Vector2(0, movement * speed);

        // clamp y-axis
        float clampedY = Mathf.Clamp(transform.position.y, -8f, 8f);
        transform.position = new Vector2(transform.position.x, clampedY);
    }
}
