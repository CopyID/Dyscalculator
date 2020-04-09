using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class ChanceScene : MonoBehaviour
{
    private gamemanager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("gamemanager").GetComponent<gamemanager>();
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
