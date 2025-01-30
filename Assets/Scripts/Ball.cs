using UnityEngine;
using UnityEngine.UIElements;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        ResetPosition();
    }

    public void ResetPosition()
    {
        rb.position = new(0f, 0f);
        float initX = -1f;
        float initY = Random.Range(-0.5f, 0.5f);

        Vector2 direction = new Vector2(initX, initY).normalized;
        rb.linearVelocity = direction * speed;
    }
}
