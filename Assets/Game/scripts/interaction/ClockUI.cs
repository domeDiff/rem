using UnityEngine;
using System.Collections;
using TMPro;
using Unity.VisualScripting;

public class ClockUI : MonoBehaviour
{
    [SerializeField] private GameObject clockTimeText;
    [SerializeField] private float displayDuration = 2f;

    private Coroutine hideCoroutine;

    public void ShowTime()
    {
        clockTimeText.SetActive(true);

        if(hideCoroutine != null)
        {
            StopCoroutine(hideCoroutine);
        }

        hideCoroutine = StartCoroutine(HideAfterDelay());
    }

    private IEnumerator HideAfterDelay()
    {
        yield return new WaitForSeconds(displayDuration);
        clockTimeText.SetActive(false);
        hideCoroutine = null;
    }
}
