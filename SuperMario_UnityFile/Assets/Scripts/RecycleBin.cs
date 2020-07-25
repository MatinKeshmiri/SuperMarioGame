using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleBin : MonoBehaviour
{
    public GameObject Garbages;
    public GameObject Spawn;
    public static int garbageDistinguishValue = 1000;
    public bool isColliding = false;
    [SerializeField] SoundFxManager sfx;
    [SerializeField] AudioClip bigScoreSfx;

    void OnTriggerEnter2D()
    {
        if (isColliding) return;
        isColliding = true;

        if (PlayerController.GarbageNum >= 1)
        {

            Instantiate(Garbages, Spawn.transform.position, Quaternion.identity);
            ScoreManager.score += garbageDistinguishValue;
            sfx.PlaySoundFX(bigScoreSfx);
        }

        Destroy(this);
        print("Everybody puts once");
    }

    public void Update()
    {
        isColliding = false;
    }
}

