//--------------------------------
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NavPanel : MonoBehaviour
{
	[SerializeField] SoundFxManager sfx;
	[SerializeField] AudioClip changeLevelSfx;
	//Scene to change
	public int SceneDestination = 0;

	//Target position for player when they arrive at destination
	public Vector3 TargetPosition = Vector3.zero;

	//Last position to set player
	public static Vector3 LastTarget = Vector3.zero;
	//int ActiveScene;


	void Start()
	{

	}
	//--------------------------------
	public void SceneChange()
	{

		GameData.PlayerPosX = TargetPosition.x;
		GameData.PlayerPosY = TargetPosition.y;
		GameData.ActiveScene = SceneDestination;
		//Application.LoadLevel(SceneDestination);
		SceneManager.LoadScene(SceneDestination);
		
	}
	//--------------------------------
	void OnTriggerEnter2D(Collider2D other)
	{
		//If not player entered, then exit
		if (!other.gameObject.CompareTag("Player"))
			return;

		//Lock player controls
		PlayerController.PlayerInstance.CanControl = false;

		sfx.PlaySoundFX(changeLevelSfx);
		SceneChange();
	}
	//--------------------------------
}
//--------------------------------