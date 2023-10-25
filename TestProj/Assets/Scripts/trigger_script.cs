using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class trigger_script : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other){

        Debug.Log("enter");

    }

    private void OnTriggerExit2D(Collider2D other){

        Debug.Log("exit");

    }

    private void OnTriggerStay2D(Collider2D other){

        Debug.Log("stay");

    }

}
