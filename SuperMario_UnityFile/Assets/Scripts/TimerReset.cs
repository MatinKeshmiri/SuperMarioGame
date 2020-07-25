using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TimerReset : MonoBehaviour
{
	public float ResetTime = 4f;

	void Start()
	{
		Invoke("Reset", ResetTime);
	}

	void Reset()
	{
		//
		PlayerController.Reset();
		//GameData.PlayerPosX = -4.6f;
		//GameData.PlayerPosY = -1.44f;
		//GameData.ActiveScene = 1;

		//Application.LoadLevel(1);
		SceneManager.LoadScene(1);
	}
}