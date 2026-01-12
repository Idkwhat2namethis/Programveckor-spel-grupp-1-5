using UnityEngine;

public class Gambling : MonoBehaviour
{
    void Start()
    {
        int randomNumber = Random.Range(1, 11);
        print(randomNumber);
        if (randomNumber == 2 || randomNumber == 6 || randomNumber == 8 || randomNumber == 10)
        {
            print(" Du har fått en 2x poäng multiplikator under 60 sekunder! ");
        }
        else if (randomNumber == 3 || randomNumber == 9 || randomNumber == 5)
        {
            print(" Du har uppgraderat till en ny svamp med starkare effekter! ");
        }
        else if (randomNumber == 1 || randomNumber == 4)
        {
            print(" Du har fått 15 svampar! ");

        }
        else
        {
            print(" Du har uppgraderat till en ny substans! ");
        }
    }

}

