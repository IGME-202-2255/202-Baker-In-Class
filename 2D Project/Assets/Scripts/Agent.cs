using UnityEngine;

public abstract class Agent : MonoBehaviour
{
    [SerializeField]
    Vector2 velocity;

    [SerializeField]
    Vector2 acceleration;

    [SerializeField]
    float maxSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = CalcForces();

        //  Add this frames forces to the agent
        velocity += acceleration * Time.deltaTime;

        //  Move to a new location
        transform.Translate(velocity * Time.deltaTime);
    }

    protected abstract Vector2 CalcForces();

    public Vector2 Seek(Vector2 targetPos)
    {
        // Calculate desired velocity
        Vector2 desiredVelocity = (Vector3)(targetPos) - transform.position;

        // Set desired = max speed
        desiredVelocity = desiredVelocity.normalized * maxSpeed;

        // Calculate seek steering force
        Vector2 seekingForce = desiredVelocity - velocity;

        // Return seek steering force
        return seekingForce;
    }

    public Vector2 Flee(Vector2 targetPos)
    {
        // Calculate desired velocity
        Vector2 desiredVelocity = transform.position - (Vector3)(targetPos);

        // Set desired = max speed
        desiredVelocity = desiredVelocity.normalized * maxSpeed;

        // Calculate seek steering force
        Vector2 seekingForce = desiredVelocity - velocity;

        // Return seek steering force
        return seekingForce;
    }
}
