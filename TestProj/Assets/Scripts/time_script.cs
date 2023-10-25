using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class time_script : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public game_script game;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer.text = game.game_time.ToString();
    }
}
