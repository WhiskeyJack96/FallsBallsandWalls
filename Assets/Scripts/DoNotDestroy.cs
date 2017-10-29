using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{
    private bool created = false;

    void Awake ()
    {
        if (!created)
        {
            //DontDestroyOnLoad(transform.gameObject);
            created = true;
        }
        else
        {
            Destroy(transform.gameObject);
        }
    }
}
