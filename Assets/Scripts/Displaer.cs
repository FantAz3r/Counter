using TMPro;
using UnityEngine;

public class Displaer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counterText;

    private int _count = 0;

    private void Start()
    {
        counterText.text = "—четчик: " + _count;
    }

    public void UpdateCounterText(int count)
    {
        Debug.Log("—четчик: " + count);
        counterText.text = "—четчик: " + count; 
    }
}

