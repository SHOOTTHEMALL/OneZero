using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KillBtn : MonoBehaviour
{
    public void Kill()
    {
        //���̴� ������ �Ѿ��
        SceneManager.LoadScene(7);
    }

}
