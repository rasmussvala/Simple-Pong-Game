using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 10f;
    private float originalSpeed;
    public float speedIncrease = 1f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        originalSpeed = speed;
    }

    void Start()
    {
        ResetPosition();
    }

    public void ResetPosition()
    {
        speed = originalSpeed;
        rb.position = new Vector2(0f, 0f);
        rb.rotation = 0f;
        rb.angularVelocity = 0f;
        float initX = -1f;
        float initY = Random.Range(-0.5f, 0.5f);

        Vector2 direction = new Vector2(initX, initY).normalized;
        rb.linearVelocity = direction * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Increase speed when hitting a paddle or wall
        speed += speedIncrease;
        rb.linearVelocity = rb.linearVelocity.normalized * speed;
    }

    public Vector2 GetPosition()
    {
        return rb.position;
    }
}
