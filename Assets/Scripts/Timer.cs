using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEditor.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float timer;

    public TextMeshProUGUI txtTimer;

    private void Update()
    {
        timer -= Time.deltaTime;

        txtTimer.text = "" + timer.ToString("f0");

    }
}
