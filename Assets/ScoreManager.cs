using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public Text score;
    private double scoretracker;

    private double pointpersecond = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //scoretracker +=  Math.Round( Convert.ToDouble(pointpersecond * Time.deltaTime),2);
        scoretracker += (pointpersecond * Time.deltaTime);
        

        score.text = "Score: " + Math.Truncate(scoretracker).ToString();
    }
}
