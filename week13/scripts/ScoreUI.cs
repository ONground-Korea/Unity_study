using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    Text mtext;

    // Start is called before the first frame update
    void Start()
    {
        mtext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        mtext.text = "»πµÊ«— æ∆¿Ã≈€ ºˆ: " + PlayerPrefs.GetInt("scoreSave", 0).ToString("0");
    }
}
