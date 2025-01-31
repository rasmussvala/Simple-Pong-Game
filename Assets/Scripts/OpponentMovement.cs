using UnityEngine;

public class OpponentMovement : MonoBehaviour
{
    public float speed = 5f;

    public Ball ball;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float targetY = ball.GetPosition().y;

        float newY = Mathf.MoveTowards(rb.position.y, targetY, speed * Time.fixedDeltaTime);

        newY = Mathf.Clamp(newY, -8f, 8f);

        rb.MovePosition(new Vector2(rb.position.x, newY));
    }
}
