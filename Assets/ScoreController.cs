using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{

    public int score = 0;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        
    }

    public void AddPoint()
    {
        Debug.Log("AddPoint");
        score += 1;
    }

    public void ClearScore()
    {
        score = 0;
    }
}
