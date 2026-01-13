using UnityEngine;

public class polis : MonoBehaviour
{
    Rigidbody2D rigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.linearVelocity = new Vector2(-3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -6)
        {
            float randomYposition = Random.Range(3.5f, -3.5f);
            transform.position = new Vector2(6, randomYposition);
            if (rigidbody.linearVelocity.x > 26)
            {
                rigidbody.linearVelocity += new Vector2(-3f, -0);
            }
        }


    }
}

