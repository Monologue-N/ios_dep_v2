﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarMove : MonoBehaviour
{
    private Animator m_animator;
    private bool m_move = false;
    private string sceneName;
    private string TAG = "[StarMove] ";
    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
        Scene scene1 = SceneManager.GetActiveScene();
        sceneName = scene1.name;
                if (sceneName == "Level_3")
        {
            m_animator.SetTrigger("Move");
            m_move = true;

        } else {
            //Debug.Log(TAG + "Never enter move mode");
        }
        
    }
}
