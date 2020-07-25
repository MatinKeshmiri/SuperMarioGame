using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PowerUpBlock : MonoBehaviour
{
    public bool isBlockFull = true;
    [SerializeField] GameObject mushroomPrefab;
    [SerializeField] GameObject Spawn;
    //[SerializeField] int MushCount = 1;

    BoxCollider2D block;
    Bounds hitzone;

    private void Start()
    {
       
        block = gameObject.GetComponent<BoxCollider2D>();
        hitzone = block.bounds;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Vector3 impactPoint;

        impactPoint = other.contacts[0].point;

        bool isBelowBrick = impactPoint.y <= hitzone.min.y;

        if (isBelowBrick)
        {
            
            Instantiate(mushroomPrefab, Spawn.transform.position, Spawn.transform.rotation);
           
            Debug.Log("sweet spot \t : " + impactPoint);
            
        }     
    }   
}
