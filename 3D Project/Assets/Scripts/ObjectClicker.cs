using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    public RaycastHit hit;

    [SerializeField]
    LayerMask rayMask;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, rayMask))
        {
            Debug.Log(hit.transform.gameObject.name);

            hit.transform.localScale = Vector3.one * 20;
        }
    }

    private void OnDrawGizmos()
    {
        if (hit.transform != null)
        {
            Gizmos.color = Color.magenta;

            Gizmos.DrawLine(transform.position, hit.point);
        }
    }
}
