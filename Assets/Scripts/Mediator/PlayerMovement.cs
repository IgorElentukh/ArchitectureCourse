using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _direction;
    private Vector3  _startPosition;

    private void Awake()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        _direction = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * _direction * _speed * Time.deltaTime);
    }

    public void SetStartPosition()
    {
        transform.position = _startPosition;
    }
}
