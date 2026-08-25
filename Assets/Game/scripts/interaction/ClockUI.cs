using UnityEngine;
using TMPro;

public class ClockUI : MonoBehaviour
{
    [SerializeField] private GameObject clockTimeText;

    public void ShowTime()
    {
        clockTimeText.SetActive(true);
    }

    public void HideTime()
    {
        clockTimeText.SetActive(false);
    }
}
