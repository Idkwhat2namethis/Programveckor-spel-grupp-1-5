using TMPro;
using UnityEngine;

public class scores3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public TextMeshProUGUI gui;
    float score1 = 1000;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        score1 += Time.deltaTime * 20f;
        gui.text = Mathf.RoundToInt(score1).ToString();





    }

}