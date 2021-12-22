using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Knife : MonoBehaviour
{
    public Button grab;
    public Button nothx;
    public Button grabing;
    public bool isGrab;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += (scene, mode) =>
        {
            if(scene.buildIndex == 2 || scene.buildIndex == 10)
            {
                grab = GameObject.Find("Grab").GetComponent<Button>();
                nothx = GameObject.Find("Nothx").GetComponent<Button>();
                if (grab != null && nothx != null)
                {
                    grab.gameObject.SetActive(false);
                    nothx.gameObject.SetActive(false);
                }
            }
            
        };

    }

    private void Update()
    {
        if (isGrab == true)
        {
            grabing.gameObject.SetActive(true);
        }
        else
        {
            grabing.gameObject.SetActive(false);
        }
    }
}
