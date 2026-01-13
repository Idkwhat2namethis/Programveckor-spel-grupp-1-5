using TMPro;
using UnityEngine;

public class Svamp_poäng : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI gui;
    float score1 = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        score1 += 1f;
        gui.text = Mathf.RoundToInt(score1).ToString();
    }
}


