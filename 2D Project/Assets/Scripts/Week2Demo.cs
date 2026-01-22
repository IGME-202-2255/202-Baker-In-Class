using UnityEngine;

public class Week2Demo : MonoBehaviour
{
    [SerializeField]
    int favNum = 0;

    public Rigidbody2D rigidbody2D;

    public GameObject spawnPrefab;

    public Rigidbody2D spawnedRB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        spawnedRB = Instantiate(rigidbody2D);

        spawnedRB.gravityScale = Random.value;

        //Destroy(rigidbody2D);
    }
}
