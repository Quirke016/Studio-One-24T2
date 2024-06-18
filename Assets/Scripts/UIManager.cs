using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timer;
    float timerTime = 0;

    public void Update()
    {
        timerTime += Time.deltaTime;
        timer.text = ((int)timerTime).ToString();
    }
}
