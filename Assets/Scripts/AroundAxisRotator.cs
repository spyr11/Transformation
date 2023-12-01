using UnityEngine;

public class AroundAxisRotator : MonoBehaviour
{  
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.localRotation = transform.localRotation * Quaternion.AngleAxis(_speed * Time.deltaTime, Vector3.up);
    }
}
