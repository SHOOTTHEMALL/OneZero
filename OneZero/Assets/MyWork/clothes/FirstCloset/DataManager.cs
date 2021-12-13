using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public closet closet = null;
    private void Awake()
    {
        if(instance!=null)
        {
            Destroy(this);
            return;
        }
        instance = this;

        Load();
    }

    public void Save()
    {
        string str = JsonUtility.ToJson(this);

        StreamWriter sw = new StreamWriter(Application.dataPath + "/Resources/data.txt");
        Debug.Log(Application.dataPath);

        sw.Write(str);
        sw.Close();
    }

    public void Load()
    {
        StreamReader sr = new StreamReader(Application.dataPath + "/Resources/data.txt");

        string str = sr.ReadToEnd();

        closet = JsonUtility.FromJson<closet>(str);

        sr.Close();
    }
}