using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] private float speed = 5f;
    [SerializeField] private Vector3 direction = Vector3.zero;
    [SerializeField] private float rotationSpeed = 180f;
    [SerializeField] private string horizontalInputAxis = "Horizontal";
    [SerializeField] private string verticalInputAxis = "Vertical";
    [SerializeField] private const string cameraRotateAxis = "Mouse X";
    void Start()
    {
        
    }

   
    void Update()
    {
        Move();
        Rotate();
    }

    private void Rotate()
    {
        float rotationInput = Input.GetAxis(cameraRotateAxis);
        transform.Rotate(Vector3.up, rotationInput * rotationSpeed * Time.deltaTime);
    }

    private void Move()
    {
        float horizontal = Input.GetAxis(horizontalInputAxis);
        float vertical = Input.GetAxis(verticalInputAxis);
        direction = new Vector3(horizontal, 0, vertical).normalized;
        transform.Translate(direction * speed * Time.deltaTime);
    }
    
}
