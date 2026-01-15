
using UnityEngine;
using Transform = UnityEngine.Transform;


public class ai : MonoBehaviour
{
    // hastighet
    public float speed;
    private Transform player;
    //bullet
    public GameObject playerbullet;
    float timer = 0f;
    float shootSpd = 1f;
    //random shite




    //id för spelare
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // mäter distans och rör sig för att komma nära
    void Update()
    {
        float distancefromplayer = Vector2.Distance(player.position, transform.position);
        print("maxdistance: " + speed * Time.deltaTime);

        transform.position = Vector2.MoveTowards(new(transform.position.x, transform.position.y), new(transform.position.x, player.position.y), speed * Time.deltaTime);

        //bullet grejer

        timer += Time.deltaTime;


        if (timer >= shootSpd)
        {
            Instantiate(playerbullet, transform.position, Quaternion.identity);
            timer -= shootSpd;



        }


    }


}
