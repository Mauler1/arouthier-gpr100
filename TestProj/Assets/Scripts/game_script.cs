using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_script : MonoBehaviour
{
    public float game_time;

    // Update is called once per frame
    void Update()
    {
        game_time -= Time.deltaTime;

        if(game_time <= 0.0f){
            SwitchScene();
        }
    }

    public void SwitchScene(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = 0;

        if(currentSceneIndex + 1 < SceneManager.sceneCountInBuildSettings){
            nextSceneIndex = currentSceneIndex + 1;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }
}
