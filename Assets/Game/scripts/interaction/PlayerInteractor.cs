using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private InteractionUI interactionUI;
    [SerializeField] private float interactionDistance = 3f;

    private Rem_InputActions inputActions;

    private IInteractable currentInteractable;

    private void Awake()
    {
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

    private void Update()
    {
        CheckForInteractable();

        if(currentInteractable != null && inputActions.Player.Interact.WasPressedThisFrame()) {
            currentInteractable.Interact();
        }
    }

    private void CheckForInteractable()
    {
        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, interactionDistance))
        {
            currentInteractable = hit.collider.GetComponent<IInteractable>();

            if (currentInteractable != null)
            {
                interactionUI.Show();
                Debug.Log("looking at: " + currentInteractable);
            }
            else{
                interactionUI.Hide();
                Debug.Log("no interactable");
            }
        }
    }
}