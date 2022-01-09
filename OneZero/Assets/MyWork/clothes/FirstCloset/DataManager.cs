using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json.Linq;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public closet closet = null;
    public clothesData clotha;

    const string saveFileName = "data.sav";

    //public string[] data;
    private void Awake()
    {
        if(instance!=null)
        {
            Destroy(this);
            return;
        }
        instance = this;
        Save();
        Load();
    }

    string getFilePath(string fileName)
    {
        return Application.persistentDataPath + "/" + fileName;
    }

    public void Save()
    {
        //json 데이터 가공
        JObject jObj = new JObject();
        jObj.Add("componentName", GetType().ToString());

        JArray jdataObject = new JArray();
        jObj.Add("clothes", jdataObject);

        JObject JOBjClota = new JObject();
        JOBjClota.Add("index",0);
        JOBjClota.Add("love",30);

        JObject JOBjClota1 = new JObject();
        JOBjClota1.Add("index", 1);
        JOBjClota1.Add("love", 20);


        JArray JARRAY1 = new JArray();
        JARRAY1.Add(JOBjClota);
        JARRAY1.Add(JOBjClota1);

        jdataObject.Add(JARRAY1.ToString());

        print(jObj);

        StreamWriter sw = new StreamWriter(getFilePath(saveFileName));
        sw.WriteLine(jObj.ToString());
        sw.Close();
    }

    public void Load()
    {
        print("Load to : " + getFilePath(saveFileName));
        StreamReader sr = new StreamReader(getFilePath(saveFileName));

        string str = sr.ReadToEnd();

        closet = JsonUtility.FromJson<closet>(str);

        sr.Close();

        JObject jObj = JObject.Parse(str);
        clotha.index = jObj["clothes"]["index"].Value<int>();
        clotha.love = jObj["clothes"]["love"].Value<int>();
    }
}
