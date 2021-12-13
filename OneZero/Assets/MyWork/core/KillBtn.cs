using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KillBtn : MonoBehaviour
{
    private Knife knife;

    private void Awake()
    {
        knife = FindObjectOfType<Knife>();
    }

    public void getKnife()
    {
        knife.isGrab = true;
        GameManager.instance.youChoose = true;
        knife.grab.gameObject.SetActive(false);
        knife.nothx.gameObject.SetActive(false);
        GameManager.instance.isGrabb = true;
    }

    public void Nothx()
    {
        knife.isGrab = false;
        GameManager.instance.youChoose = true;
        knife.grab.gameObject.SetActive(false);
        knife.nothx.gameObject.SetActive(false);
        GameManager.instance.isGrabb = false;
    }
    public void Kill()
    {
        //���̴� ������ �Ѿ��
        SceneManager.LoadScene(8);
    }

}
