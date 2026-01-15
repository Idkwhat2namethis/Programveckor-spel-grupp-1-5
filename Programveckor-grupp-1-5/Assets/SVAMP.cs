using UnityEngine;

public class SVAMP : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            float RandomXposition = Random.Range(-6.35f, 3.80f);
            transform.position = new Vector2(RandomXposition, 0);
            float RandomYposition = Random.Range(2.0f, -3.40f);
            transform.position = new Vector2(RandomYposition, 0);

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        float RandomXposition = Random.Range(-6.35f, 3.80f);
        transform.position = new Vector2(RandomXposition, 0);
        float RandomYposition = Random.Range(2.0f, -3.40f);
        transform.position = new Vector2(RandomYposition, 0);
    }
}
