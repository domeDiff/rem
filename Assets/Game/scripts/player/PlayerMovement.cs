using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 4f;
    [SerializeField] private float gravity = -20f;

    private CharacterController controller;
    private Rem_InputActions inputActions;

    private float verticalVelocity;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        inputActions = new Rem_InputActions();
    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
    }

    private void OnDisable()
    {
        inputActions.Player.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        Vector2 input = inputActions.Player.Move.ReadValue<Vector2>();
        Vector3 move = transform.right * input.x + transform.forward * input.y;

        if(controller.isGrounded && verticalVelocity < 0)
        {
            verticalVelocity = -2f;
        }
        verticalVelocity += gravity * Time.deltaTime;
        Vector3 velocity = move * moveSpeed;
        velocity.y = verticalVelocity;

        controller.Move(velocity * Time.deltaTime);
    }
}
