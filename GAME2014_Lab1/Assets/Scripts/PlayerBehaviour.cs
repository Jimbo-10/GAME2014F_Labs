using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{

    /*[SerializeField]
    InputActionAsset inputActions;

    InputAction moveInput;

    [SerializeField]
    Boundary verticalBoundary;

    [SerializeField]
    Boundary horizontalBoundary;

    Vector2 direction;

    public Camera camera;

    public Vector2 destination;

    [SerializeField]
    float speed;*/

    [SerializeField]
    float horizontalForce;

    [SerializeField]
    Boundary bounds;

    [SerializeField]
    [Range(0f, 1f)]

    float decay;

    private Rigidbody2D rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*MobileInput();
        CheckBoundaries();*/
        Move();
    }

   float GetTouchDirection()
    {
        if(Touchscreen.current == null)
        {
            return 0.0f;
        }

        var touch = Touchscreen.current.primaryTouch;

        if (!touch.press.IsPressed())
        {
            return 0.0f;
        }

        Vector2 pos = touch.position.ReadValue();

        if(pos.x < Screen.width / 2.0f)
        {
            return -1.0f;
        }

        return 1.0f;
    }

    void Move()
    {
        float x = GetTouchDirection();
        rigidbody.AddForce(new Vector2(x * horizontalForce, 0.0f));
    }

    void CheckBounds()
    {
        Vector2 pos = rigidbody.position;

        if (pos.x < bounds.min)
        {
            pos.x = bounds.min;
        }

        if (pos.x > bounds.max)
        {
            pos.x = bounds.max;
        }

        rigidbody.position = pos;
    }

    void FixedUpdate()
    {
        rigidbody.linearVelocity *= decay;
        CheckBounds();
    }
}
