using System.Collections;
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
        // reset all moving values of the ball
        speed = originalSpeed;
        rb.position = Vector2.zero;
        rb.rotation = 0f;
        rb.angularVelocity = 0f;
        rb.linearVelocity = Vector2.zero;
        // transform.rotation = Quaternion.identity; // donno what this does

        // trigger a coroutine to add a delay before ball is being lauched
        StartCoroutine(LaunchBallAfterDelay(1f));
    }

    private IEnumerator LaunchBallAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        float initX = Random.Range(0, 2) == 0 ? -1f : 1f;
        float initY = Random.Range(-0.5f, 0.5f);

        Vector2 direction = new Vector2(initX, initY).normalized;
        rb.linearVelocity = direction * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // increase speed when hitting a paddle or wall
        speed += speedIncrease;
        rb.linearVelocity = rb.linearVelocity.normalized * speed;
    }

    public Vector2 GetPosition()
    {
        return rb.position;
    }
}
