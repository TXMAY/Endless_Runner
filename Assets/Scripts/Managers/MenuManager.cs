using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] Text buttonText;
    void Awake()
    {
        buttonText = GetComponentInChildren<Text>();
    }

    public void OnEnter()
    {
        buttonText.fontSize = 72;
    }

    public void OnLeave()
    {
        buttonText.fontSize = 48;
    }

    public void OnSelect()
    {
        buttonText.fontSize = 36;
    }
    public void Execute()
    {

    }

    public void Shop()
    {

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
