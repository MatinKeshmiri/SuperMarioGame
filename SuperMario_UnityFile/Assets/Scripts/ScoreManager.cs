using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    Text text;

    public static int score=0;

	// Use this for initialization
	void Start ()
    {
        text = GetComponent<Text>();
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        text.text = "Score: " + score;
        
    }
}
