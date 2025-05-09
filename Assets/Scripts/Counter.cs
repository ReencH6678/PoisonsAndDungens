using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public event Action<float> VelueChendeg;

    [SerializeField] private float _deley;
    [SerializeField, Min(0)] private float _startCount;

    private float _currentCount;
    private bool _isOn = false;

    private void Start()
    {
        _currentCount = _startCount;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isOn = !_isOn;

            if (_isOn)
            {
                StartCoroutine(Countup(_deley));
            }
            else
            {
                StopCoroutine(Countup(_deley));
            }

        }
    }

    private IEnumerator Countup(float deley)
    {
        while (_isOn)
        {
            var wait = new WaitForSecondsRealtime(deley);

            VelueChendeg?.Invoke(_currentCount++);

            yield return wait;
        }
    }
}
