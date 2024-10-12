using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VNEngine;
public class KasinoTable : MonoBehaviour
{
    public float DiceNum;
    public float EneDiceNum;
    public Text NumTextP;
    public Text NumTextE;
    public Text WinAndLose;
    public GameObject WinDiceAgain;
    public GameObject LoseDiceAgain;
    public GameObject pingDiceAgain;
    private bool isDialogueActive = false;
    void Start()
    {
        DiceNum = 0;
        EneDiceNum = 0;
        WinDiceAgain = GameObject.Find("ConversationToReplay_Lose");
        LoseDiceAgain = GameObject.Find("ConversationToReplay_Win");
        pingDiceAgain = GameObject.Find("ConversationToReplayping");

    }

  


    void Update()
    {

        if (CasinoManager.DiceEnd == true)
        {
            Destroy(transform.parent.gameObject, 0.1f);
        }


        if (hat.Goal == true && !isDialogueActive)
        {
            isDialogueActive = true; // 设置为对话进行中
            if (DiceNum > EneDiceNum)
            {
                // 更新 UI 文本
                NumTextP.text = ("" + DiceNum);
                NumTextE.text = ("" + EneDiceNum);
                WinAndLose.color = Color.red;
                WinAndLose.text = ("You Win!");
                VNSceneManager.scene_manager.Start_Conversation(WinDiceAgain);
            }
            else if (DiceNum < EneDiceNum)
            {
                NumTextP.text = ("" + DiceNum);
                NumTextE.text = ("" + EneDiceNum);
                WinAndLose.color = Color.blue;
                WinAndLose.text = ("You Lose..");
                VNSceneManager.scene_manager.Start_Conversation(LoseDiceAgain);
            }
            else // DiceNum == EneDiceNum
            {
                NumTextP.text = ("" + DiceNum);
                NumTextE.text = ("" + EneDiceNum);
                WinAndLose.color = Color.white;
                WinAndLose.text = ("Try Again?");
                VNSceneManager.scene_manager.Start_Conversation(pingDiceAgain);
            }
        }
        else
        {
            DiceNum = 0;
            EneDiceNum = 0;
        }
    }
        private void OnTriggerStay(Collider other)
    {
        if (hat.Goal == true)
        {
            
            if (other.name == "1")
            {
                DiceNum += 1;
                Destroy(other.gameObject);
            }
            if (other.name == "2")
            {
                DiceNum += 2;
                Destroy(other.gameObject);
            }
            if (other.name == "3")
            {
                DiceNum += 3;
                Destroy(other.gameObject);
            }
            if (other.name == "4")
            {
                DiceNum += 4;
                Destroy(other.gameObject);
            }
            if (other.name == "5")
            {
                DiceNum += 5;
                Destroy(other.gameObject);
            }
            if (other.name == "6")
            {
                DiceNum += 6;
                Destroy(other.gameObject);
            }
            if (other.name == "1E")
            {
                EneDiceNum += 1;
                Destroy(other.gameObject);
            }
            if (other.name == "2E")
            {
                EneDiceNum += 2;
                Destroy(other.gameObject);
            }
            if (other.name == "3E")
            {
                EneDiceNum += 3;
                Destroy(other.gameObject);
            }
            if (other.name == "4E")
            {
                EneDiceNum += 4;
                Destroy(other.gameObject);
            }
            if (other.name == "5E")
            {
                EneDiceNum += 5;
                Destroy(other.gameObject);
            }
            if (other.name == "6E")
            {
                EneDiceNum += 6;
                Destroy(other.gameObject);
            }
        }
        }
    }
