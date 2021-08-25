using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class saveManager : MonoBehaviour
{
    const string saveFileName = "FuckFuck.sav";

    public Text haeunLove;

    private string yName;
    string getFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            yName = haeunLove.text;
            print("Save to : " + getFilePath(saveFileName));

            StreamWriter sw = new StreamWriter(getFilePath(saveFileName));
            Debug.Log(yName);
            sw.WriteLine(yName);
            //절대 중요
            sw.Close();

            
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            print("Load to : " + getFilePath(saveFileName));

            StreamReader sr = new StreamReader(getFilePath(saveFileName));

            print(sr.ReadLine());

            sr.Close();
        }
    }
}
