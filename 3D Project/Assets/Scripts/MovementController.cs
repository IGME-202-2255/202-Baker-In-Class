using UnityEngine;
using UnityEngine.InputSystem;


public class MovementController : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 5f;

    [SerializeField]
    Vector3 inputDirection = Vector3.zero;

    [SerializeField]
    Vector3 groundNormal = Vector3.zero;

    [SerializeField]
    LayerMask groundLayer;

    Vector3 surfaceForward = Vector3.zero;
    Vector3 surfaceRight = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currectForward = Vector3.zero;
        Vector3 currectRight = Vector3.zero;

        RaycastHit hit;
        if (Physics.Raycast(transform.position + (Vector3.up * 5f), Vector3.down, out hit, Mathf.Infinity, groundLayer))
        {
            surfaceForward= Vector3.Cross(transform.right, hit.normal);

            currectForward = surfaceForward * (inputDirection.z * moveSpeed * Time.deltaTime);



            surfaceRight = Vector3.Cross(hit.normal, surfaceForward);

            currectRight = surfaceRight * (inputDirection.x * moveSpeed * Time.deltaTime);
        }
        else
        {
            currectForward = transform.forward * (inputDirection.z * moveSpeed * Time.deltaTime);

            currectRight = transform.right * (inputDirection.x * moveSpeed * Time.deltaTime);
        }

        

        transform.position += currectForward + currectRight;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        inputDirection = context.ReadValue<Vector2>();

        inputDirection.z = inputDirection.y;
        inputDirection.y = 0f;
    }
}
