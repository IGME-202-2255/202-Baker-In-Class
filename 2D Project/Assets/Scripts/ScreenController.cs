using UnityEngine;

public class ScreenController : MonoBehaviour
{
    public Vector2 screenSize = Vector2.zero;

    public Vector2 screenPadding = Vector2.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        screenSize.y = Camera.main.orthographicSize * 2f;

        screenSize.x = screenSize.y * Camera.main.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;

        Vector2 paddedScreenSize = screenSize - screenPadding;

        Gizmos.DrawWireCube(Camera.main.transform.position, paddedScreenSize);
    }
}
