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
}
