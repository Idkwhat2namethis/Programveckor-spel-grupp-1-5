using UnityEngine;

public class backgrund : MonoBehaviour
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

    }
}
