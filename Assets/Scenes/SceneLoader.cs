using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void loadChess(){
        SceneManager.LoadScene("Chess");
    }
    
    public void loadMenu(){
        SceneManager.LoadScene("Menu");
    }

    void Update()
    {
        
    }
}
