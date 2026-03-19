using UnityEngine;

public class Seeker : Agent
{
    public GameObject target;

    public Vector2 seekForce = Vector2.zero;

    public float seekWeight = 1f;

    protected override Vector2 CalcForces()
    {
        seekForce = Seek(target.transform.position) * seekWeight;

        // Seek something
        return seekForce;
    }
}
