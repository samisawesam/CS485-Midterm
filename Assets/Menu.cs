﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Sam Shulman
public class Menu : MonoBehaviour
{

    public int buttonWidth;
    public int buttonHeight;
    private int origin_x;
    private int origin_y;

    public int sceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        buttonWidth = 200;
        buttonHeight = 50;
        origin_x = Screen.width / 2 - buttonWidth / 2;
        origin_y = Screen.height / 2 - buttonHeight / 2; ;
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(origin_x, origin_y, buttonWidth, buttonHeight), "Game 1"))
        {
            sceneIndex = 1;
            SceneManager.LoadScene(sceneIndex);
        }

        if (GUI.Button(new Rect(origin_x, origin_y + buttonHeight + 10, buttonWidth, buttonHeight), "Exit"))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
    			Application.Quit();
#endif
        }
    }
}
