﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class ChanceScene : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName:tag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}