using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public static class DataClass
{//일반
    public static int hisHerat; //얘가 계속 저장되어야한다.

    public static void InitData()
    {
        hisHerat = 0;
    }
}
