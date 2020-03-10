using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameQuiter : MonoBehaviour
{
    [SerializeField]
    private KeyCode _quiterKey = KeyCode.Escape;

    protected virtual void Update()
    {
        if(Input.anyKeyDown && Input.GetKeyDown(_quiterKey))
        {
            quit();
        }
    }

    private void quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
