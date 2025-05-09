using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _deley;
    [SerializeField, Min(0)] private float _startCount;

    [SerializeField] private TextMeshProUGUI _text;

    private float _currentCount;
    private bool _isOn = true;

    private void Start()
    {
        _currentCount = _startCount;
        StartCoroutine(Countup(_deley));
    }

    private void Update()
    {
        
    }

    private IEnumerator Countup(float deley)
    {
        var wait = new WaitForSecondsRealtime(deley);

        while (_isOn)
        {
            if (Input.GetMouseButton(0))
            {
                _isOn = !_isOn;
            }

            _currentCount++;
            DisplayCountup(_currentCount);

            yield return wait;
        }
    }

    private void DisplayCountup(float count)
    {
        _text.text = count.ToString("");
    }
}
