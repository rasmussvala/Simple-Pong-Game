using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // move body
        var direction =
            Input.GetAxis("Vertical"); // smoothed input (–1 down to +1 up) based on how long the key is held
        _rigidbody.linearVelocity = new Vector2(0f, direction * speed);

        // clamp y-axis
        var clampedY = Mathf.Clamp(transform.position.y, -8f, 8f);
        transform.position = new Vector2(transform.position.x, clampedY);
    }
}