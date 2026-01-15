using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
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
        score1 += Time.deltaTime * 20f;
        gui.text = Mathf.RoundToInt(score1).ToString();
        {
            if (score1 == 500)
            {
                SceneManager.LoadScene(3);
            }
        }
        if (score1 == 2000)
        {
            SceneManager.LoadScene(4);
        }
    }

}