using UnityEngine;
using UnityEngine.InputSystem;


public class MovementController : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 5f;

    [SerializeField]
    Vector3 inputDirection = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currectForward = transform.forward * (inputDirection.z * moveSpeed * Time.deltaTime);

        Vector3 currectRight = transform.right * (inputDirection.x * moveSpeed * Time.deltaTime);

        transform.position += currectForward + currectRight;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        inputDirection = context.ReadValue<Vector2>();

        inputDirection.z = inputDirection.y;
        inputDirection.y = 0f;
    }
}
