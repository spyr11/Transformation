using UnityEngine;

public class ForwardMover : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;

    private void Start()
    {
        _rigidbody.velocity = transform.forward * _speed;
    }
}
