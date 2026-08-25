using UnityEngine;

public class BedroomReturn : MonoBehaviour
{
    [SerializeField] private DreamState dreamState;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        if (!dreamState.hasSeenClock)
            return;

        dreamState.hasReturnedToBedroom = true;

        Debug.Log("player has returned to bedroom");
    }
}
