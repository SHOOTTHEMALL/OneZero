using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

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
        }
    }

    public void NextDialogue()
    {
        text_Dialogue.DOText(dialogue[count].dialogue, dialogue[count].dialogue.Length / 5, false);
        //DOTween.Clear();
        text_Dialogue.text = "";
        count++;
    }

    public void Show()
    {
        //������ �Լ��� ���� �Ƹ��� ���� ���߿� �ð����� ��������
    }
}
