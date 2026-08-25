using UnityEngine;

public class BedroomExit : MonoBehaviour
{
    [SerializeField] private DreamState dreamState;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        if(!dreamState.hasSeenClock) 
            return;

        Debug.Log("player has left after seeing clock");
    }
}
