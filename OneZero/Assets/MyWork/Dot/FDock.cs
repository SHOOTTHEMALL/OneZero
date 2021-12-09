using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class FDock : MonoBehaviour, TalkTip 
{
    [System.Serializable]
    public class Dialogue
    {
        [TextArea]
        public string dialogue;
    }

    [SerializeField]
    private Text text_Dialogue;
    [SerializeField] private Dialogue[] dialogue;
    private int count = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (count < dialogue.Length)
                NextDialogue();
            else if(SceneManager.GetActiveScene().buildIndex == 1)
                SceneManager.LoadScene(2);
            else if(SceneManager.GetActiveScene().buildIndex == 5 || SceneManager.GetActiveScene().buildIndex == 6 || SceneManager.GetActiveScene().buildIndex == 7)
            {
                SceneManager.LoadScene(9);
            }
            else if(SceneManager.GetActiveScene().buildIndex == 9)
            {
                SceneManager.LoadScene(10);
            }
        }
    }

    public void NextDialogue()
    {
        text_Dialogue.text = "";
        text_Dialogue.DOText(dialogue[count].dialogue, dialogue[count].dialogue.Length / 5, false);
        //DOTween.Clear();
        count++;
    }

    public void Show()
    {
        //보여줄 함수가 없음 아마도 딱히 나중에 시간나면 넣을지도
    }
}
