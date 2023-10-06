using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Range(0.0f, 10.0f)]
    [Tooltip("Speed of the player")]
    public float speed = 5.0f;
    public float smoothTime = 0.1f;
    private Rigidbody2D body;

    private Vector2 movementInput;
    private Vector2 smoothedInput;
    private Vector2 currentVelocity;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        movementInput = new Vector2(horizontalInput, verticalInput);

        smoothedInput = Vector2.SmoothDamp(smoothedInput, movementInput, ref currentVelocity, smoothTime);

        // Vector3 movement = new Vector3(horizontalInput, verticalInput);
        // transform.position += movement * speed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        body.velocity = smoothedInput * speed;
    }
}
