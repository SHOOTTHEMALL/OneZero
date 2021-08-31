using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class LetsTalk : MonoBehaviour
{
    [System.Serializable]
    public class Dialogue
    {
        [TextArea]
        public string dialogue;
        public string nameO;
        public string nameZ;
        public Sprite One;
        public Sprite Zero;
    }

    [SerializeField]
    private SpriteRenderer sprite_One;
    [SerializeField]
    private SpriteRenderer sprite_Zero;
    [SerializeField]
    private SpriteRenderer sprite_dialogue;
    [SerializeField]
    private Text text_Dialogue;
    [SerializeField]
    private Text oneTalk;
    [SerializeField]
    private Text zeroTalk;

    [SerializeField] private Dialogue[] dialogue;

    //private bool isDialogue = true;
    private float start = 0;
    private int count = 0;
    private bool isDialogue = false;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    void Update()
    {
        start += Time.deltaTime;
        if(start>5)
        {
            ShowThem();
            GameObject obj = GameObject.Find("TalkSiabl");
        }

        if(isDialogue)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (count < dialogue.Length)
                    NextDialogue();
                else
                    SceneManager.LoadScene("Etc");
            }
        }
    }

    private void ShowThem()
    {
        sprite_dialogue.gameObject.SetActive(true);
        sprite_One.gameObject.SetActive(true);
        sprite_Zero.gameObject.SetActive(true);
        text_Dialogue.gameObject.SetActive(true);
        oneTalk.gameObject.SetActive(true);
        zeroTalk.gameObject.SetActive(true);

        //count = 0; 이 씨발련ㅋㅋㅋㅋㅋㅋ드디어 ㅈ ㅏㅂ았다
        isDialogue = true;
    }

    private void NextDialogue()
    {
        text_Dialogue.text = " ";
        text_Dialogue.DOText(dialogue[count].dialogue, 2);
        oneTalk.text = dialogue[count].nameO;
        zeroTalk.text = dialogue[count].nameZ;
        sprite_One.sprite = dialogue[count].One;
        sprite_Zero.sprite = dialogue[count].Zero;
        count++;
    }

}
