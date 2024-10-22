using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CongratsUI : MonoBehaviour
{
    private TextMeshProUGUI rewardText;
    void Start()
    {
        rewardText = GetComponent<TextMeshProUGUI>();
        rewardText.text = "";
    }

    void Update()
    {
        if ((ScoreManager.score >= 100) && (ScoreManager.score < 110))
        {
            rewardText.text = "¡Menuda Racha!";
        } 
        else if (ScoreManager.score == 185)
        {
            rewardText.text = "EXTERMINIO";
        }
        else {
            rewardText.text = "";
        }
    }
}