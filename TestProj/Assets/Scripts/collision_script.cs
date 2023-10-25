using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class collision_script : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other){

        Debug.Log("Enter");

    }

    private void OnCollisionExit2D(Collision2D other){

        Debug.Log("Exit");

    }

    private void OnCollisionStay2D(Collision2D other){

        Debug.Log("Stay");

    }
}
