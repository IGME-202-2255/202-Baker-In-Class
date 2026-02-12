using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;

    public Vector3 direction = Vector3.zero;

    public Rigidbody2D rBoday;

    public TextMesh velocityLabel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //  Calc Velocity for this frame
        Vector3 velocity = direction * speed * Time.deltaTime;

        transform.Translate(velocity);

        velocityLabel.text = string.Format("{0}", velocity.magnitude);

        //transform.Translate(-velocity);
    }

    private void FixedUpdate()
    {
        //Vector3 velocity = direction * speed * Time.fixedDeltaTime;

        //rBoday.MovePosition(velocity);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Found Gold");
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(rBoday.transform.position, direction * speed);

        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(transform.position, transform.localScale.x);
    }

}
