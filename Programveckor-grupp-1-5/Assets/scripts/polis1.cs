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
            float randomYposition = Random.Range(-3.5f, 0f);
            transform.position = new Vector2(-6, randomYposition);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Polis"))
        {
            float randomYposition = Random.Range(-3.5f, 0f);
            transform.position = new Vector2(-6, randomYposition);

            rb.linearVelocity = new Vector2(5f, 0f);
            rb.angularVelocity = 0f;
        }
    }

}

