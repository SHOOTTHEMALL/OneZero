using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KillBtn : MonoBehaviour
{
    public void Kill()
    {
        //죽이는 씬으로 넘어가기
        SceneManager.LoadScene(7);
    }

}
