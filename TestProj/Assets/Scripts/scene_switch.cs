using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_switch : MonoBehaviour
{

    private void Update(){

        if(Input.GetMouseButtonDown(0)){
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
