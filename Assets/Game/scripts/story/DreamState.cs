using UnityEngine;

public class DreamState : MonoBehaviour
{
    public bool hasSeenClock = false;

    public bool hasReturnedToBedroom = false;

    public float timeSinceClockSeen = 0f;
    public float clockAnamolyTime = 10f;

    private void Update()
    {
        if (hasSeenClock)
        {
            timeSinceClockSeen += Time.deltaTime;
        }

        
    }
}
