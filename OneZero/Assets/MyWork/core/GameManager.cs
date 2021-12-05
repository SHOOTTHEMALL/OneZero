using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public sayManager sayManager;
    public Animator sayPanel;
    public typeEffect say;
    public GameObject sObj;
    public bool show;
    public int sayIndex;
    public Knife kill;

    public void Action(GameObject scanObj)
    {
        sObj = scanObj;
        ObjData objData = sObj.GetComponent<ObjData>();
        Say(objData.id, objData.npc);
        sayPanel.SetBool("isShow", show);
    }

    void Say(int id, bool npc)
    {
        string sayData = "";
        if (say.isAni)
        {
            say.setMsg("");
            return;
        }
        else
        {
            sayData = sayManager.GetSay(id, sayIndex);
        }



        if (sayData == null)
        {
            if(sObj.CompareTag("Zero"))
            {
                //대사는 스페이스바를 눌러도 더이상 변동 X여야함
                kill.grab.gameObject.SetActive(true);
                kill.nothx.gameObject.SetActive(true);
            }
            else
            {
                sayIndex = 0;
                show = false;
                return;
            }
        }

        if (npc)
        {
            say.setMsg(sayData.Split(':')[0]);
        }
        else
        {
            say.setMsg(sayData);
        }

        show = true;
        sayIndex++;
    }
}
