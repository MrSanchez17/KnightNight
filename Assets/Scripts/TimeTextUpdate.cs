using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeTextUpdate : MonoBehaviour
{
    public void SetTimeText(float time)
    {
        GetComponent<TMP_Text>().text = "Time: " + System.Math.Round(time,1);
    }
}
