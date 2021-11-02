using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int score;
    public Text ScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            AddScore(10);
        }
    }

    public void AddScore(int addedScore)
    {
        score += addedScore;
        ScoreText.text = score.ToString();
        Debug.Log("Added score");
    }
}
