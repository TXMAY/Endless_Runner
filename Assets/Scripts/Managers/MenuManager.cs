using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void Execute()
    {
        StartCoroutine(SceneryManager.Instance.AsyncLoad(1));
    }

    public void Shop()
    {
        Debug.Log("Shop");
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
