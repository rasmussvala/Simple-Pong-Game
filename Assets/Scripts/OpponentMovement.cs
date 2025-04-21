using UnityEngine;

public class OpponentMovement : MonoBehaviour
{
    public float speed = 5f;
    public Ball ball;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        UpdatePaddlePosition();
    }

    private void UpdatePaddlePosition()
    {
        var currentBallPosition = ball.GetPosition().y;

        // find next position
        var nextPositionY = Mathf.MoveTowards(_rigidbody.position.y, currentBallPosition, speed * Time.fixedDeltaTime);
        var nextPositionClampedY = Mathf.Clamp(nextPositionY, -8f, 8f);

        // move paddle
        var target = new Vector2(_rigidbody.position.x, nextPositionClampedY);
        _rigidbody.MovePosition(target);
    }
}