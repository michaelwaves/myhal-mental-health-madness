using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue=0;
    TextMeshProUGUI myScore;
    void Start()
    {
        myScore = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        myScore.text = "Mental Health Score:" + scoreValue;
    }
}
