using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private const string Horizontal = nameof(Horizontal);
    private const string Vertical = nameof(Vertical);

    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _moveSpeed;

    private Animator _animator;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        Rotate();
        Move();
    }

    private void Rotate() 
    {
        float rotation = Input.GetAxis(Horizontal);

        transform.Rotate(rotation * _rotationSpeed * Time.deltaTime * Vector3.up);
    }

    private void Move()
    {
        float direction = Input.GetAxis(Vertical);
        float distance = direction * _moveSpeed * Time.deltaTime;

        _animator.SetFloat("Speed", direction);
        transform.Translate(distance * Vector3.forward);
    }
}
