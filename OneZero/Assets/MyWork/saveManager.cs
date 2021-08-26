using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class saveManager : MonoBehaviour
{
    const string saveFileName = "FuckFuck.sav";

    public Text haeunLove;

    private string ori;
    string getFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ori = haeunLove.text;
            print("Save to : " + getFilePath(saveFileName));

            StreamWriter sw = new StreamWriter(getFilePath(saveFileName));
            Debug.Log(ori);
            sw.WriteLine(ori);
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
