using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{
    private bool created = false;
    public static DoNotDestroy instance = null;

    void Awake ()
    {
       if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
       else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
}
