using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sayManager : MonoBehaviour
{
    Dictionary<int, string[]> sayData;
    // Start is called before the first frame update
    void Awake()
    {
        sayData = new Dictionary<int, string[]>();
        GeData();
    }

    // Update is called once per frame
    void GeData()
    {
        sayData.Add(1, new string[] { "죄책감 때문에 예민해 지지 말자." });
        sayData.Add(10, new string[] { "알아? 알아 몰라 아냐고" });
    }

    public string GetSay(int id, int sayIndex)
    {
        if (sayIndex == sayData[id].Length)
            return null;

        else
            return sayData[id][sayIndex];
    }
}
