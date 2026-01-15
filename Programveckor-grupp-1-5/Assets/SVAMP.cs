using UnityEngine;

public class SVAMP : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(-7, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            float RandomYposition = Random.Range(1.40f, -4.5f);
            transform.position = new Vector2(RandomYposition, 0);

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            float RandomYposition = Random.Range(1.40f, -4.5f);
            transform.position = new Vector2(RandomYposition, 0);

        }
    }
}
