using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarManager : MonoBehaviour
{
    public GameObject Star1, Star2, Star3;
    public float rotationRate = 100f;
    public GameObject can;

    public void Update()
    {
        Star1.gameObject.SetActive(false);
        Star2.gameObject.SetActive(false);
        Star3.gameObject.SetActive(false);

        if (PlayerController.Health > 0)
        {

            if (ScoreManager.score >= 10000)
            {
                Star1.gameObject.SetActive(true);
                transform.RotateAround(can.transform.position, can.transform.up, rotationRate * Time.deltaTime);
                Star2.gameObject.SetActive(true);
                transform.RotateAround(can.transform.position, can.transform.up, rotationRate * Time.deltaTime);
                Star3.gameObject.SetActive(true);
                transform.RotateAround(can.transform.position, can.transform.up, rotationRate * Time.deltaTime);
            }
            else if (ScoreManager.score >= 5000)
            {
                Star1.gameObject.SetActive(true);
                transform.RotateAround(can.transform.position, can.transform.up, rotationRate * Time.deltaTime);
                Star2.gameObject.SetActive(true);
                transform.RotateAround(can.transform.position, can.transform.up, rotationRate * Time.deltaTime);
            }
            else if (ScoreManager.score >= 2000)
            {
                Star1.gameObject.SetActive(true);
                transform.RotateAround(can.transform.position, can.transform.up, rotationRate * Time.deltaTime);
            }
        }
    }
}
