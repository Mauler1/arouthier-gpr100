using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class end : MonoBehaviour
{
    public TextMeshProUGUI scoreBoard;
    private int score = score_script._score;

    // Start is called before the first frame update
    void Start()
    {
        scoreBoard.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
