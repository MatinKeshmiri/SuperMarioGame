using UnityEngine;
using System.Collections;

public class MushroomScript : MonoBehaviour
{
   
    void OnTriggerEnter2D()
    {
        if (PlayerController.PlayerState == 0)
        {
            PlayerController.PlayerState = 1;
            //power up player
           
            PlayerController.Health = 100f;
            
        }

        Destroy(this.gameObject);
    }

}   