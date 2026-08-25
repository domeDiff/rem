using Unity.VisualScripting;
using UnityEngine;

public class ClockInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private ClockUI clockUI;
    [SerializeField] private DreamState dreamState; 
    public void Interact()
    {
        clockUI.ShowTime();

        if (!dreamState.hasSeenClock)
        {
            Debug.Log("reads 3:17 AM");
            dreamState.hasSeenClock = true;
            return;
        }

        if(dreamState.timeSinceClockSeen >= dreamState.clockAnamolyTime)
        {
            Debug.Log("still reads 3:17 AM");
        }

        else
        {
            Debug.Log("reads 3:17 AM");
        }

        dreamState.hasSeenClock = true;

        
    }
}
