﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PersistentManagerScript : MonoBehaviour
{
    private static PersistentManagerScript _instance;

    public static PersistentManagerScript Instance 
    { 
        get { return _instance; }
    }

    public int LevelIdx;
    public int maxUnlockedIdx;
    public int[] LevelShots;
    public int[] bestLevelShots;
    public int[] levelStars;
    public int[] levelStarCnt;
    public bool starIsAlive;  // temp variable for present levels, will change to levelStarCnt later
    public int totalLevels;
    public bool blockedByUI;
    public bool muted;

    private string TAG = "[Singleton] ";

    private void Awake()
    {
        
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            Debug.Log(TAG + "It is destroyed");
            return;   
        }
            _instance = this;
            starIsAlive = false;
            LevelShots = new int[10];
            bestLevelShots = new int[10];
            levelStars = new int[10]{0, 1, 1, 1, 1, 2, 2, 2, 2, 3};
            levelStarCnt = new int[10];
            totalLevels = 9;
            blockedByUI = false;
            muted = false;
            
            for (int i = 0; i < 10; i++)
            {
                bestLevelShots[i] = 1000;
            }
            levelStarCnt = new int[10];
            maxUnlockedIdx = 1;
            Debug.Log(TAG + "This is initialized");

            // Keep the singleton 
            DontDestroyOnLoad(this.gameObject);
    }
}
