using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        transform.Translate(_moveSpeed * Time.deltaTime * Vector3.forward);
    }

    private void Rotate()
    {
        transform.Rotate(_rotationSpeed * Time.deltaTime * Vector3.up);
    }
}
