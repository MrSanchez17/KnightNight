using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTextBehaviour : MonoBehaviour
{
    public void SetScoreText(int score)
    {
        GetComponent<TMP_Text>().text = "Score: " + score;
    }
}
