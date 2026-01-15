using UnityEngine;

public class polis1 : MonoBehaviour
{
    Rigidbody2D rb;
    public float spawnDelay = 2f;
    bool waiting = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(5f, 0f);
    }

    void Update()
    {
        if (transform.position.x > 0f)
        {
            RespawnWithDelay();
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Polis"))
        {
            RespawnWithDelay();
        }
    }

    void RespawnWithDelay()
    {
        if (waiting) return;
        waiting = true;

        transform.position = new Vector2(2000, 2000);

        rb.linearVelocity = Vector2.zero;
        rb.angularVelocity = 0f;

        Invoke(nameof(Respawn), spawnDelay);
    }
    void Respawn()
    {
        float randomYposition = Random.Range(-3.5f, 0f);
        transform.position = new Vector2(-6, randomYposition);

        rb.linearVelocity = new Vector2(5f, 0f);
        waiting = false;

    }
}

