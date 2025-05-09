using TMPro;
using UnityEngine;

[RequireComponent(typeof(Counter))]
public class CounterView : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private TextMeshProUGUI _text;

    private void OnEnable()
    {
        _counter.VelueChendeg += DisplayCountup;
    }

    private void OnDisable()
    {
        _counter.VelueChendeg -= DisplayCountup;
    }

    private void DisplayCountup(float count)
    {
        _text.text = count.ToString("");
    }
}
