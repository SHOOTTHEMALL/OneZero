using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sayManager : MonoBehaviour
{
    Dictionary<int, string[]> sayData;
    public saveManager sav;
    // Start is called before the first frame update
    void Awake()
    {
        sayData = new Dictionary<int, string[]>();
        sav = FindObjectOfType<saveManager>();
        //Debug.Log(sav.ori.name);
        GetData();
    }

    // Update is called once per frame
    void GetData()
    {
        sayData.Add(1, new string[] { "응애응애" ,"와 너무 멋져요 팬이에요 꺆꺆 " });// + sav.ori.name이것이 왜 널이 뜨는것일까?
        sayData.Add(2, new string[] { "허위의 반대말은?", "사실! 깔깔깔ㅋㅋㅋ ","앞이라던가 뒤라던가" });
        sayData.Add(3, new string[] { "세우깡 마시졍" });
        sayData.Add(4, new string[] { "주인공이다. 너무 멋지다" });
        sayData.Add(5, new string[] { "눈물이 차오르내야`~~~~" });
        sayData.Add(6, new string[] { "코코몽 코코몽! 이히ㅣㅣ잏" });
    }

    public string GetSay(int id, int sayIndex)
    {
        if (sayIndex == sayData[id].Length)
            return null;
        else
            return sayData[id][sayIndex];
    }

    public bool CheckExist(int id, int index)
    {
        return sayData.ContainsKey(id) && sayData[id].Length > index ;
    }
}
