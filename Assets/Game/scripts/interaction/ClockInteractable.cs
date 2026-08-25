using Unity.VisualScripting;
using UnityEngine;

public class ClockInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private ClockUI clockUI;
    [SerializeField] private DreamState dreamState; 
    public void Interact()
    {
        clockUI.ShowTime();

        dreamState.hasSeenClock = true;

        Debug.Log("shows 3:17 AM");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
}
