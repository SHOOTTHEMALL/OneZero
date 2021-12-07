using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public sayManager sayManager;
    public Animator sayPanel;
    public typeEffect say;
    public GameObject sObj;
    public bool show;
    public int sayIndex;
    public Knife kill;
    public bool youChoose = false;
    public bool isGrab = false;
    public Button grabing;

    private void Awake()
    {
        if(instance !=null)
        {
            Destroy(this);
        }
        instance = this;
    }

    private void Start()
    {
        DataClass.InitData();
    }

    public void Action(GameObject scanObj)
    {
        sObj = scanObj;
        ObjData objData = sObj.GetComponent<ObjData>();
        
        Say(objData);

        sayPanel.SetBool("isShow", show);
    }

    void Say(ObjData data)
    {
        string sayData = "";

        if (say.isAni)
        {
            say.setMsg("");
            return;
        }
        
        if (!sayManager.CheckExist(data.id, sayIndex))
        {
            if(sObj.CompareTag("Zero"))
            {
                if (youChoose)
                {
                    sayIndex = 0;
                    data.id++;
                    if(sayManager.CheckExist(data.id, sayIndex) && data.id != 3)
                    {
                        sayData = sayManager.GetSay(data.id, sayIndex);
                        say.setMsg(sayData);
                        //더 이어질 대화가 있다면
                    }
                    else
                    {
                        // 더 이어질 대화가 없다면
                        //Debug.Log("종료");
                        SceneManager.LoadScene(2);
                    }
                    
                }
                else
                {
                    kill.grab.gameObject.SetActive(true);
                    kill.nothx.gameObject.SetActive(true);
                    return;
                }

            }
            else
            {
                sayIndex = 0;
                show = false;
                return;
            }
        }
        else
        {
            sayData = sayManager.GetSay(data.id, sayIndex);
            say.setMsg(sayData);
        }

        show = true;
        sayIndex++;
    }
    public void Kill()
    {
        //죽이는 씬으로 넘어가기
        SceneManager.LoadScene(7);
    }
}
