
using Unity.VisualScripting;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private float sensitivity = 0.1f;
    [SerializeField] private float maxLookAngle = 85f;
    private Rem_InputActions inputActions;

    private float verticalRotation;

    private void Awake()
    {
        inputActions = new Rem_InputActions();
    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void OnDisable()
    {
        inputActions.Player.Disable();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector2 lookInput=inputActions.Player.Look.ReadValue<Vector2>();
        float mouseX = lookInput.x * sensitivity;
        float mouseY = lookInput.y * sensitivity;
        transform.Rotate(UnityEngine.Vector3.up * mouseX);

        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -maxLookAngle, maxLookAngle);

        cameraTransform.localRotation = Quaternion.Euler(verticalRotation,0f,0f);
    }
}
