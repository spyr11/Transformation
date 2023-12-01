using UnityEngine;

public class ScaleConverter : MonoBehaviour
{    [SerializeField] private float _speed;

    private Vector3 _currentScale;

    private void Start()
    {
        _currentScale = transform.localScale;        
    }

    private void Update()
    {
        transform.localScale += _currentScale* _speed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        Debug.Log(transform.localScale.y);
    }
}
