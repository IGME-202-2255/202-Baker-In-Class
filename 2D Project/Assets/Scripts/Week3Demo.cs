using UnityEngine;
using UnityEngine.InputSystem;

public class Week3Demo : MonoBehaviour
{
    public float speed = 4f;

    public Vector2 movement = Vector2.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //  Player Movement
        Vector2 playerMovement = movement * speed * Time.deltaTime;

        transform.position = transform.position + (Vector3)playerMovement;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        //Debug.Log("Hey");

        movement = context.ReadValue<Vector2>();
    }

    public void OnAction(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
}
