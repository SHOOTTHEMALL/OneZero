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
        GeData();
    }

    private void Start()
    {
        sav = FindObjectOfType<saveManager>();
    }

    // Update is called once per frame
    void GeData()
    {
        sayData.Add(1, new string[] { "응애응애" ,"와 너무 멋져요 팬이에요 꺆꺆"});// + sav.ori.name이것이 왜 널이 뜨는것일까?
    }

    public string GetSay(int id, int sayIndex)
    {
        if (sayIndex == sayData[id].Length)
            return null;

        else
            return sayData[id][sayIndex];
    }
}
