using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _timer;

    public TextMeshProUGUI txtTimer;

    private void Update()
    {
        _timer -= Time.deltaTime;

        txtTimer.text = "" + _timer.ToString("f0");
        if (_timer <= 0)
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    
}
