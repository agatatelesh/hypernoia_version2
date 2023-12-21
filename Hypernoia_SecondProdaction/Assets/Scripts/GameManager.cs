using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Quit();
            Application.Quit();
            Debug.Log("You Quit a Game");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
            Debug.Log("You Restart a Game");
        }      

    }

    public void Quit(){
        UnityEditor.EditorApplication.isPlaying = false;//closing unity edidtor window 
    }

    public void Restart(){
        //SceneManager.LoadSceneAsync(0);//Loads the Scene asynchronously in the background.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//reload Current open scene
    }
}
