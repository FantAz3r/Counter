using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private int _count = 0;
    [SerializeField] private bool _isCounting = false;
    [SerializeField] private float _delay = 0.5f;
    [SerializeField] private Displaer displaer;

    private WaitForSeconds wait;

    private void Start()
    {
        wait = new WaitForSeconds(_delay);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_isCounting)
            {
                StopCounting();
            }
            else
            {
                StartCounting();
            }
        }
    }

    private void StartCounting()
    {
        _isCounting = true;
        StartCoroutine(Count());
    }

    private void StopCounting()
    {
        _isCounting = false;
        StopCoroutine(Count());
    }

    private IEnumerator Count()
    {
        while (_isCounting)
        {
            yield return wait;
            _count++;
            displaer.UpdateCounterText(_count);
        }
    }
}
