using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    int OneSecond = 0;

    void Start()
    {
        StartCoroutine("Timer");
    }

    void Update()
    {
        if (!DataManager.Instance.PlayerDie)
        {
            score.text = ": " + OneSecond;
        }
        
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1f);

        OneSecond++;
        StartCoroutine("Timer");
    }

}
