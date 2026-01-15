using UnityEngine;

public class backgrund : MonoBehaviour
{
    Rigidbody2D rigidbody;
    SpriteRenderer sr;
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.linearVelocity = new Vector2(-5, 0);
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -74)
        {
            transform.position = new Vector2(78, 0);
        }



    }

}
