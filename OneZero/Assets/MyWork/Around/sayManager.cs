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
        sayData.Add(1, new string[] { "오 안녕!!!!" ,"기다리느라 목빠지는 줄 알았어" +sav.ori.name,
        "만나서 반가어","너 칼 좋아하니?","좋아하면 Yes를 누르고, 아니면 No를 눌러"});// + sav.ori.name이것이 왜 널이 뜨는것일까?
        sayData.Add(2, new string[] { "나는 무엇을 골랐는지 모르겠지만", "Yes를 눌렀면","왼쪽 상단에 칼이 보이실거야.","이게 바로! 히로인를 죽일 수 있는 마법의 칼!!", 
        "누르면 바로 죽일 수 있어.","마음에 안드시면 걍 죽여버려","죽이는 게 싫으면 그에게 잘 보이도록 옷을 이쁘게 입어" , "그러면 그 애가 널 좋아해서 너랑 사귀어줄거야","화이팅이다맨이야~~"});
        sayData.Add(3, new string[] { "(당신을 애써 무시하고 있다)" });
        sayData.Add(4, new string[] { sav.ori.name+"!","안녕~ㅎㅎ♥","게임좋아해?"+"우리 학교 끝나고 피시방갈까??","준비해서 맞짱피시방에서 보자!ㅎㅎㅎ" });
        sayData.Add(5, new string[] { "오, 일단은 죽이지 않았나보네" ,"아니면 이미 죽여보고 다시 온건가?","내가 선택여부도 개발했으면 좋았을텐데"});
        sayData.Add(6, new string[] { "어차피 사귈 수 없을거야","호감도 얻기 어려우니깐, 이 게임 모티브가 슈게임이거든 ","뭐, 적어도 여기선 플레이어도 선택할 수 있으니까","그냥 히로인을 죽였으면 좋겠어"});
        sayData.Add(7, new string[] { "아..안녕"+sav.ori.name });
        sayData.Add(8, new string[] { "오늘도 같이 놀거지? 이번에는 어떤 옷을 입을지 기대하고 있을게" + sav.ori.name });
        sayData.Add(9, new string[] { "으...","널 보기도 싫어" });
        sayData.Add(10, new string[] { "뭐야 그 뿔이랑 목","진짜 이상하다니까.." });
        sayData.Add(11, new string[] { ";;;" });
        sayData.Add(12, new string[] { "(당신을 위아래로 본다)","하.." });
        sayData.Add(13, new string[] { "저기...","너 머리랑 목 괜찮아?","같이 보건실 갈까?" });
        sayData.Add(14, new string[] { "괴물같은놈", "나였으면 자살했겠다 ㅋㅋㅋ" });
        sayData.Add(15, new string[] { "?", "..?","..??.?/.///????" });
        sayData.Add(16, new string[] { "우욱.." });
        sayData.Add(17, new string[] { "너 진짜 이상해진거 알아?", "처음부터 이랬던 거 아니잖아" });
        sayData.Add(18, new string[] { "ㅉㅉ", "빨리 꺼져" });
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
