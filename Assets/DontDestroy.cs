using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    // plays music on main menu
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("menuMusic");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }
}

