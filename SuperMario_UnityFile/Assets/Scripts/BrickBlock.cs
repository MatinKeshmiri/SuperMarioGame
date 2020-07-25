using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BrickBlock : MonoBehaviour
{
    public int BgarbageValue = 100;
    public bool isBlockFull = true;

    [SerializeField] GameObject spawnPoint;
    [SerializeField] GameObject garbagePrefab;
    [SerializeField] int garbageCount = 1;

    [SerializeField] SoundFxManager sfx;
    [SerializeField] AudioClip coinSfx;

    BoxCollider2D block;
    Bounds hitzone;

    private void Start()
    {
        if (garbageCount <= 0)
            isBlockFull = false;

        block = gameObject.GetComponent<BoxCollider2D>();
        hitzone = block.bounds;
    }

    IEnumerator OnCollisionEnter2D(Collision2D other)
    {
        Vector3 impactPoint;

        impactPoint = other.contacts[0].point;

        bool isBelowBrick = impactPoint.y <= hitzone.min.y;

        if (garbageCount != 0 && isBelowBrick)
        {
            Object garbage = Instantiate(garbagePrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);

            yield return new WaitForSeconds(.3f);

            Debug.Log("sweet spot \t : " + impactPoint);
            sfx.PlaySoundFX(coinSfx);
            
            Destroy(garbage);
            garbageCount--;
            ScoreManager.score += BgarbageValue;
            PlayerController.GarbageNum += 1;
        }

        if (garbageCount == 0)
        {
      
            isBlockFull = false;

            print("You're breaking me... ");
        }
    }

}
