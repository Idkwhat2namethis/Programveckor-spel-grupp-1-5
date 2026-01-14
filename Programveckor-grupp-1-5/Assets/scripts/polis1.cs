using UnityEngine;

public class polis1 : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(5f, 0f);
    }

    void Update()
    {
        if (transform.position.x > 0f)
        {
            Destroy(gameObject);
        }
    }
}

