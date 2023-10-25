using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score_script : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    static public int _score;

    void Start(){
        _score = 0;
    }

    public void AddScore(){

        _score++;
        scoreText.text = _score.ToString();

    }

}
