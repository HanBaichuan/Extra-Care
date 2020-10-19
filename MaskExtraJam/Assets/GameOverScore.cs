using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour
{
    // Start is called before the first frame update
    private Text text;
    private static int highScore;
    void Start()
    {
        if (CustomerHead.score > highScore){
            highScore = CustomerHead.score;
        }
        text = GetComponent<Text>();
        text.text = "High score: " + highScore; 
        CustomerHead.score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
