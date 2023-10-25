using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class random_collectible : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other){

        RepositionCollectible();

    }

    void RepositionCollectible(){

        float newX = UnityEngine.Random.Range(-5, 5);
        float newY = UnityEngine.Random.Range(-3, 3);
        Vector2 newPos = new Vector2(newX, newY);
        transform.position = newPos;

    }

}
