using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPlayBotton : MonoBehaviour
{
    public void ChangeMenuScene(string scenename)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(scenename);
    }
    
}
