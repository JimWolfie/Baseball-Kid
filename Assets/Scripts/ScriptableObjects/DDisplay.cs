using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDisplay : MonoBehaviour
{
    public Dialog conversation;
    public GameObject speakerLeft;
    public GameObject speakerRight;

    private DialogAdvancer leftUI;
    private DialogAdvancer rightUI;

    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        leftUI = speakerLeft.GetComponent<DialogAdvancer>();
        rightUI = speakerRight.GetComponent<DialogAdvancer>();

        leftUI.Speaker = conversation.speakerLeft;
        rightUI.Speaker = conversation.spreakerRight;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            AdvanceConversation();

        }
    }

    void AdvanceConversation()
    {
        if(index < conversation.lines.Length)
        {
            DisplayLine();
            index +=1;
        } else
        {
            leftUI.Hide();
            rightUI.Hide();
            index =0;

        }
    }
    void DisplayLine()
    {
        Line line = conversation.lines[index];
        Character character = line.character;

        if(leftUI.SpeakerIs(character))
        {
            SetLine(leftUI, rightUI, line.text);
        }else
        {
            SetLine(rightUI, leftUI, line.text);
        }
    }
    void SetLine(
        DialogAdvancer activeUI,
        DialogAdvancer inactiveUI,
        string text)
    {
        activeUI._Dialog = text;
        activeUI.Show();
        inactiveUI.Hide();

    }
}
