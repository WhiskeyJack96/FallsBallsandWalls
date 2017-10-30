using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIBackButton_Restart : MonoBehaviour
{
    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name); // loads current scene
    }

}
