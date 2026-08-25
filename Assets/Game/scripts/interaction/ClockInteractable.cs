using Unity.VisualScripting;
using UnityEngine;

public class ClockInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private ClockUI clockUI;
    public void Interact()
    {
        clockUI.ShowTime();

        Debug.Log("shows 3:17 AM");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
}
