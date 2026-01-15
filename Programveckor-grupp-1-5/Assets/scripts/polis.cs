using UnityEngine;

public class polis : MonoBehaviour
{
    Rigidbody2D rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.linearVelocity = new Vector2(-7, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -12)
        {
            float randomYposition = Random.Range(0, -4.4f);
            transform.position = new Vector2(12, randomYposition);

        }


    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("InversPolis"))
        {
            float randomYposition = Random.Range(0, -3.5f);
            transform.position = new Vector2(6, randomYposition);

            rigidbody.linearVelocity = new Vector2(-5f, 0f);
            rigidbody.angularVelocity = 0f;
        }
        if (collision.gameObject.CompareTag("AiPolis"))
        {
            float randomYposition = Random.Range(0, -3.5f);
            transform.position = new Vector2(6, randomYposition);

            rigidbody.linearVelocity = new Vector2(-5f, 0f);
            rigidbody.angularVelocity = 0f;
        }
    }




}

