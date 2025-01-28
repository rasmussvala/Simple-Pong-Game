using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        float initX = -1f;
        float initY = Random.Range(-0.5f, 0.5f);

        Vector2 direction = new Vector2(initX, initY).normalized;
        rb.linearVelocity = direction * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // WIP
        // if (collision.gameObject.CompareTag("Paddle"))
        // {
        //     Vector2 newDirection = Vector2.Reflect(
        //         rb.linearVelocity,
        //         collision.GetContact(0).normal
        //     );
        //     rb.linearVelocity = newDirection.normalized * speed;
        // }
        // else if (collision.gameObject.CompareTag("Wall"))
        // {
        //     rb.linearVelocity = Vector2.Reflect(rb.linearVelocity, collision.contacts[0].normal);
        // }
    }
}
