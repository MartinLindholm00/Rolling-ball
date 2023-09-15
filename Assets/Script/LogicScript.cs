using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public Text ScoreText;
    public int score;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //The Method to add the score
    public void AddScore(int ScoreAdded)
    {
        score = score + ScoreAdded;
        ScoreText.text = ScoreAdded.ToString();
    }
}
