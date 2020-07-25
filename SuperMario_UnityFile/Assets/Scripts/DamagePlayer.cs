//--------------------------------
using UnityEngine;
using System.Collections;
//--------------------------------
public class DamagePlayer : MonoBehaviour
{
    [SerializeField] SoundFxManager sfx;
    [SerializeField] AudioClip damageSfx;
    [SerializeField] AudioClip DieSfx;
    
    //Amount to damage player per second
    public float Damage = 10f;
    
    //--------------------------------
    
    void OnTriggerStay2D(Collider2D other)
    {
        //If not player then exit
        if (!other.CompareTag("Player")) return;
        //Damage player by rate
        PlayerController.Health -= Damage * Time.deltaTime;
        
        if (PlayerController.Health <= 0)
        
            sfx.PlaySoundFX(DieSfx);
            
        else sfx.PlaySoundFX(damageSfx);



    }
    //--------------------------------
}
//--------------------------------