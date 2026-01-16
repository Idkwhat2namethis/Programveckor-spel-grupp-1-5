using UnityEngine;

public class bak2 : MonoBehaviour
{
    Rigidbody2D rigidbody;
    SpriteRenderer sr;
    Animator animator;
    float score1 = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.linearVelocity = new Vector2(-5, 0);
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        animator.Play("Mushroom distortion 2");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -91)
        {
            transform.position = new Vector2(90, -5);
        }
    }
}
