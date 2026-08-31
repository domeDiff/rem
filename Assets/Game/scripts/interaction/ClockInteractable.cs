using Unity.VisualScripting;
using UnityEngine;

public class ClockInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private ClockUI clockUI;
    [SerializeField] private DreamState dreamState;

    [Header("Clock hands")]
    [SerializeField] private Transform minuteHand;
    [SerializeField] private Transform hourHand;

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
            TriggerClockAnamoly();
        }

        else
        {
            Debug.Log("reads 3:17 AM");
        }
    }

    private void TriggerClockAnamoly()
    {
        Debug.Log("still reads 3:17 AM");

        minuteHand.localRotation = Quaternion.Euler(0f, 0f, 120f);
        hourHand.localRotation = Quaternion.Euler(0f, 0f, 35f);
    }
}
