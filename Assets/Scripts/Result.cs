using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Result : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI resultText;

    void Start()
    {
        if (PlayerPrefs.GetString("Result") != null)
        {
            if(PlayerPrefs.GetString("Result")== "win")
            {
                resultText.text = "Вы выиграли" + " " + formater(PlayerPrefs.GetInt("time"));
            }
            else
            {

            }
        }           
    }
    string formater(int seter)
    {
        string textResult;
        int miliSeconds = seter % 100;
        int seconds = (seter / 100) % 60;
        int minutes = (seter / 100) / 60;

        textResult = minutes.ToString("00") + " : " + seconds.ToString("00") + " : " + miliSeconds.ToString("00");
        return textResult;
    }

}
