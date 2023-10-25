using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score_script : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int _score;

    public void AddScore(){

        _score++;
        scoreText.text = _score.ToString();

    }

}
