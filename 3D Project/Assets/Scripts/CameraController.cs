using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    Camera myCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.rotation.eulerAngles);
    }

    public void onLook(InputAction.CallbackContext context)
    {
        Vector2 inputData = context.ReadValue<Vector2>();

        //  Look Up/Down
        transform.Rotate(0, inputData.x, 0, Space.World);

        //  Look Right/Left
        myCamera.transform.Rotate(inputData.y, 0, 0);
    }

    public void OnFocus()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnUnFocus()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}
