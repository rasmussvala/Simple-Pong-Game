using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float currentSpeed;
    public float speedIncrease = 1f;
    public float startingSpeed = 10f;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPosition();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ScoringZone"))
            return;

        // add speed to ball, new direction's update automatically since
        // we have physics material on the ball. we just need to add
        // speed to the current direction.
        currentSpeed += speedIncrease;

        var direction = _rigidbody.linearVelocity.normalized;
        _rigidbody.linearVelocity = direction * currentSpeed;
    }

    public void ResetPosition()
    {
        // reset all moving values of the ball
        currentSpeed = startingSpeed;
        _rigidbody.position = Vector2.zero;
        _rigidbody.rotation = 0f;
        _rigidbody.angularVelocity = 0f;
        _rigidbody.linearVelocity = Vector2.zero;

        // trigger a coroutine to add a delay before ball is being launched
        StartCoroutine(LaunchBallAfterDelay(1f));
    }

    private IEnumerator LaunchBallAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        const float launchDirectionX = -1f; // always towards player
        var launchDirectionY = Random.Range(-0.5f, 0.5f);

        var direction = new Vector2(launchDirectionX, launchDirectionY).normalized;
        _rigidbody.linearVelocity = direction * startingSpeed;
    }

    public Vector2 GetPosition()
    {
        return _rigidbody.position;
    }
}