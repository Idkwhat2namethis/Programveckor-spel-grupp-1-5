using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
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
        rb.linearVelocity = new Vector2(0, 0);
        //flyttar med hjälp av pilar
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.linearVelocity = new Vector2(0, 5);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.linearVelocity = new Vector2(0, -5);
        }

        //flyttar med hjälp av wasd
        if (Input.GetKey(KeyCode.W))
        {
            rb.linearVelocity = new Vector2(0, 5);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.linearVelocity = new Vector2(0, -5);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(1);
    }

}
