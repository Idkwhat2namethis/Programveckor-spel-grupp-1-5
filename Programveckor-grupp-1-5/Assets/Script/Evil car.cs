using UnityEngine;

public class Evilcar : MonoBehaviour
{
    Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.linearVelocity = new Vector2(-3, 0);

    }

    // Update is called once per frame
    void Update()
    {
        w
    }
}
