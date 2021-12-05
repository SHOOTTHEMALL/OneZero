using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class saveManager : MonoBehaviour
{
    const string saveFileName = "FuckFuck.sav";

    public Text haeunLove;

    public NameClass ori = new NameClass();

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    string getFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ori.name = haeunLove.text;
            print("Save to : " + getFilePath(saveFileName));

            StreamWriter sw = new StreamWriter(getFilePath(saveFileName));
            Debug.Log(ori.name);
            sw.WriteLine(ori.name);
            //절대 중요
            sw.Close();
            Load();
            SceneManager.LoadScene(1);
        }
    }

    private void Load()
    {
        print("Load to : " + getFilePath(saveFileName));

        StreamReader sr = new StreamReader(getFilePath(saveFileName));
        ori.name = sr.ReadToEnd();

        print(sr.ReadLine());

        sr.Close();
    }
}
