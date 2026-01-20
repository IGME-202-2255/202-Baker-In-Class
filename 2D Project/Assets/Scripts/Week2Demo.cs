using UnityEngine;

public class Week2Demo : MonoBehaviour
{
    [SerializeField]
    int favNum = 0;

    public Rigidbody2D rigidbody2D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(favNum);

        rigidbody2D.gravityScale = -30f;
    }
}
