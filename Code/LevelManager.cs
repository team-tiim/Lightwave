﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    private int levelIndex = 0;
	private string[] levels = new string[] { "Lightwave/menu", "Lightwave/level001", "Lightwave/level002", "Lightwave/level003" };

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.N))
        {
            NextLevel();
        }
    }

    public void NextLevel()
    {

		Debug.Log ("HALLO");

        levelIndex++;
        if (levels.Length <= levelIndex)
        {
            levelIndex = 0;
        }
		SceneManager.LoadScene(levelIndex);

    }
}
