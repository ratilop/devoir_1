using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{

    public string sceneMenagerToLoad;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    public void LoadScenePlay()
    {
        SceneManager.LoadScene(sceneMenagerToLoad);
    }
}
