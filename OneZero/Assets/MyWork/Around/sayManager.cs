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
        sayData.Add(1, new string[] { "오 안녕하세요!!" ,"기다리느라 목빠지는 줄 알았어여" +sav.ori.name,
            "아닌가? 하은쌤이라고 해야하나?","이 버전을 받는 사람은 쌤뿐일테니깐요 ","뭐 아무튼 다시 한번 환영합니다~~짝짝짝", 
        "그런데 선생님!","칼 좋아하세영??","좋아하시면 Yes를 누르시고, 아니면 No를 눌러주세요"});// + sav.ori.name이것이 왜 널이 뜨는것일까?
        sayData.Add(2, new string[] { "저는 무엇을 골랐는지 모르겠지만", "Yes를 누르셨다면","왼쪽 상단에 칼이 보이실거에여.","이게 바로! 남주를 죽일 수 있는 마법의 칼이에요!!", 
        "누르시면 죽일 수 있어요.","마음에 안드시면 걍 죽여버려요","그럼 해피엔딩을 못보시길 바라며!! 화이팅!"});
        sayData.Add(3, new string[] { "(당신을 애써 무시하고 있다)" });
        sayData.Add(4, new string[] { sav.ori.name+"!","안녕~ㅎㅎ♥","게임좋아해?"+"우리 학교 끝나고 피시방갈까??","준비해서 맞짱피시방에서 보자!ㅎㅎㅎ" });
        sayData.Add(5, new string[] { "그 애를 죽이지 않은거에여?" ,"지금쯤이면 이미 죽여보셨을 것 같은뎅","그래도 해피엔딩은 못보실걸요?"});
        sayData.Add(6, new string[] { "어차피 호감도같은거 올리기 어려울테니까....","음, 어떤 옷을 입는지에 따라","남주의 호감도가 올라가요.",
        "해피엔딩은 절대 못보실 것 같은데..."});
        sayData.Add(7, new string[] { "아..안녕"+sav.ori.name });
        sayData.Add(8, new string[] { "오늘도 같이 놀거지? 이번에는 어떤 옷을 입을지 기대하고 있을게" + sav.ori.name });
        sayData.Add(9, new string[] { "으...","닌 친구 자퇴시켜놓고 학교를 나오고 싶냐?" });
        sayData.Add(10, new string[] { "뭐야 그 뿔이랑 목","진짜 이상하다니까.." });
        sayData.Add(11, new string[] { ";;;" });
        sayData.Add(12, new string[] { "(당신을 위아래로 본다)","너 진짜 정신병원 가봐야하는거 아니야?" });
        sayData.Add(13, new string[] { "저기...","너 머리랑 목 괜찮아?","같이 보건실 갈까?" });
        sayData.Add(14, new string[] { "괴물같은놈", "나였으면 길가다 차에 치여 죽었겠다!" });
        sayData.Add(15, new string[] { "?", "..?","..??.?/.///????" });
        sayData.Add(16, new string[] { "우욱.." });
        sayData.Add(17, new string[] { "너 진짜 이상해진거 알아?", "처음부터 이랬던 거 아니잖아" });
        sayData.Add(18, new string[] { "ㅉㅉ", "저리가. 눈에 보이질 마셈." });
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
