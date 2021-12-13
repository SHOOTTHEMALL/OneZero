using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManagerr : MonoBehaviour
{
    public static DataManagerr instance;

    public closett closett = null;
    private void Awake()
    {
        if (instance != null)
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

        StreamWriter sw = new StreamWriter(Application.dataPath + "/Resources/dataa.txt");
        Debug.Log(Application.dataPath);

        sw.Write(str);
        sw.Close();
    }

    public void Load()
    {
        StreamReader sr = new StreamReader(Application.dataPath + "/Resources/dataa.txt");

        string str = sr.ReadToEnd();

        closett = JsonUtility.FromJson<closett>(str);

        sr.Close();
    }
}
