using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Profiling;
using UnityEngine.Profiling.Memory.Experimental;

public class ScoreMenu : MonoBehaviour
{
    //public string StartScene;

    public Text WinLoseText;
    

    

    // Start is called before the first frame update
    void Start()
    {
       
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
        WinLoseText.text = GameData.EndScene;
        
    }

    // Update is called once per frame
    
   

    public void RestartButton()
    {
        ScoreManager.score = 0;
        SceneManager.LoadScene(0);

    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
