using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    // time value
    public static int indexScore;

    // view
    [SerializeField]
    private TextMeshProUGUI text;

    //bool track set on instector
    [SerializeField]
    private bool track;

    private void Start()
    {
        // for 2 scene
        // on track true 
        if (track)
        {
            StartCoroutine(timeGo());
        }
        else
        {
            //result load result
            if (PlayerPrefs.GetString("Result") != null)
            {
                if (PlayerPrefs.GetString("Result") == "win")
                {
                    text.text = "Вы выиграли" + " " + formater(PlayerPrefs.GetInt("time"));
                }
                else
                {
                    text.text = "Вы проиграли";
                }
            }
        }
    }
    //work timer
    IEnumerator timeGo()
    {
        while (true)
        {
            indexScore++;
            yield return new WaitForSecondsRealtime(0.01f);
        }
    }
    // formater
    string formater(int seter)
    {
        string textResult;
        int miliSeconds = seter % 100;
        int seconds = (seter / 100) % 60;
        int minutes = (seter / 100) / 60;

        textResult = minutes.ToString("00") + " : " + seconds.ToString("00") + " : " + miliSeconds.ToString("00");
        return textResult;
    }
    //output on track
    void Update()
    {
        if (track)
        {
            text.text = formater(indexScore);
        }
        //back to menu
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
    }
}
