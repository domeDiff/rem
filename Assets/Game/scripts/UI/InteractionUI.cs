using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class InteractionUI : MonoBehaviour
{
    [SerializeField] private GameObject interactionText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Show()
    {
        interactionText.SetActive(true);
    }

    public void Hide()
    {
        interactionText.SetActive(false);
    }
}
