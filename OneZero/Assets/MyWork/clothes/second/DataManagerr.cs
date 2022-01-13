using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json.Linq;
using System.IO;

public class DataManagerr : MonoBehaviour
{
    public static DataManagerr instance;

    public closet closett = null;
    //public clothesData clotha;

    const string saveFileName = "dataa.sav";

    //public string[] data;
    private void Awake()
    {
        if (instance != null)
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
        JOBjClota.Add("index", 0);
        JOBjClota.Add("love", 40);

        JObject JOBjClota1 = new JObject();
        JOBjClota1.Add("index", 1);
        JOBjClota1.Add("love", -20000);

        JObject JOBjClota2 = new JObject();
        JOBjClota2.Add("index", 2);
        JOBjClota2.Add("love", 10);

        JObject JOBjClota3 = new JObject();
        JOBjClota3.Add("index", 3);
        JOBjClota3.Add("love", -30);

        JObject JOBjClota4 = new JObject();
        JOBjClota4.Add("index", 4);
        JOBjClota4.Add("love", 50);

        JObject JOBjClota5 = new JObject();
        JOBjClota5.Add("index", 5);
        JOBjClota5.Add("love", 15);


        //JArray JARRAY1 = new JArray();
        jdataObject.Add(JOBjClota);
        jdataObject.Add(JOBjClota1);
        jdataObject.Add(JOBjClota2);
        jdataObject.Add(JOBjClota3);
        jdataObject.Add(JOBjClota4);
        jdataObject.Add(JOBjClota5);

        //jdataObject.Add("이름",JARRAY1.ToString());

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

        closett = JsonUtility.FromJson<closet>(str);

        sr.Close();

        //JObject jObj = JObject.Parse(str);
        //clotha.index = jObj["clothes"]["index"].Value<int>();
        //clotha.love = jObj["clothes"]["love"].Value<int>();
    }
}
