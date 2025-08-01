using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public float moveSpeed = 5f;

    Vector3 movement;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
