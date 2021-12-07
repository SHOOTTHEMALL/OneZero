﻿using System.Collections;
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
        grabing = GameObject.Find("Kill").GetComponent<Button>();
        //SceneManager.sceneLoaded += (scene, mode) => { //scnene은 지금 로딩된 씬의 정보다 mode ( 매개변수 자리 ) => { 실행할 구문; }
        //    grabing = GameObject.Find("Kill").GetComponent<Button>();
        //    if(isGrab)
        //    grabing.gameObject.SetActive(isGrab);
        //};
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
                        SceneManager.LoadScene(3);
                    }
                    
                }
                else
                {
                    kill.grab.gameObject.SetActive(true);
                    kill.nothx.gameObject.SetActive(true);
                    return;
                }
            }
            else if (sObj.CompareTag("destiny") && !(sayManager.CheckExist(data.id, sayIndex)))
            {
                data.id++;
                if (data.id == 5)
                {
                    Debug.Log("대화가 끝났고 씬을 이동시킬것입니다.");
                    SceneManager.LoadScene(3);
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