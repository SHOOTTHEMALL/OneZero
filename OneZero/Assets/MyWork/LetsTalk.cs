using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetsTalk : MonoBehaviour
{
    [System.Serializable]
    public class Dialogue
    {
        [TextArea]
        public string dialogue;
        public Sprite One;
        public Sprite Zero;
        public string oneTalk;
        public string zeroTalk;

    }

    [SerializeField]
    private SpriteRenderer sprite_One;
    [SerializeField]
    private SpriteRenderer sprite_Zero;
    [SerializeField]
    private SpriteRenderer spirte_Dialogue;
    [SerializeField]
    private Text text_One;
    [SerializeField]
    private Text text_Zero;
    [SerializeField]
    private Text text_Dialogue;

    private bool isDialogue = false;
    private int count = 0;
    private float start = 0;

    [SerializeField] private Dialogue[] dialogue;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        start += Time.deltaTime;
        if(start>5)
        {
            ShowThem();
        }
    }

    public void ShowThem()
    {
        spirte_Dialogue.gameObject.SetActive(true);
        sprite_One.gameObject.SetActive(true);
        sprite_Zero.gameObject.SetActive(true);
        text_Dialogue.gameObject.SetActive(true);

        count = 0;
        isDialogue = true;
        NextDialogue();
    }

    private void NextDialogue()
    {
        text_Dialogue.text = dialogue[count].dialogue;
        text_One.text = dialogue[count].oneTalk;
        text_Zero.text = dialogue[count].zeroTalk;
        sprite_One.sprite = dialogue[count].One;
        sprite_Zero.sprite = dialogue[count].Zero;
        count++;
    }
}
