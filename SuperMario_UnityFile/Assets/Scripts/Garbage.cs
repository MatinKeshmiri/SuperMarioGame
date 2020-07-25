using System.Collections;
//using System.Collections.Generic;
using UnityEngine;



public class Garbage : MonoBehaviour
{
    public int garbageValue = 50;


    public bool isColliding = false;
    private void OnTriggerEnter2D(Collider2D other)

    {
        if (!other.CompareTag("Player"))
           return;

        if (isColliding) return;
        isColliding = true;
        
        ScoreManager.score += garbageValue;
            
        PlayerController.GarbageNum += 1;
        
        Destroy(gameObject);
    }

    public void Update()
    {
    isColliding = false;
    }

}    
