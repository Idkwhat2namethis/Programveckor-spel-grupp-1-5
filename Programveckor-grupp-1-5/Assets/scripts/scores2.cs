using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scores2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public TextMeshProUGUI gui;
    float score1 = 500;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        score1 += Time.deltaTime * 20f;
        gui.text = Mathf.RoundToInt(score1).ToString();



        if (score1 >= 1000)
        {
            SceneManager.LoadScene(4);
        }
    }

}