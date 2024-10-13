using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VNEngine;
public class KasinoTable : MonoBehaviour
{
    public float DiceNum;
    public float EneDiceNum;
    public Text NumTextP; // 直接引用 Text 组件
    public Text NumTextE;
    public Text WinAndLose;
    public GameObject WinDiceAgain;
    public GameObject LoseDiceAgain;
    public GameObject pingDiceAgain;
    public bool isDialogueActive = false;
    public GameObject DiceM;

    void Start()
    {
        DiceNum = 0;
        EneDiceNum = 0;
        WinDiceAgain = GameObject.Find("ConversationToReplay_Lose");
        LoseDiceAgain = GameObject.Find("ConversationToReplay_Win");
        pingDiceAgain = GameObject.Find("ConversationToReplayping");

        
        ResetGameState();
    }

    void Update()
    {
        // 始终更新 UI 文本
        NumTextP.text = DiceNum.ToString();
        NumTextE.text = EneDiceNum.ToString();
        Debug.Log($"DiceNum: {DiceNum}, EneDiceNum: {EneDiceNum}, Goal: {DiceM.GetComponent<DiceManager>().Goal}");

        // 如果 Goal 达成，开始更新胜负结果
        if (DiceM.GetComponent<DiceManager>().Goal == true && !isDialogueActive &&DiceNum!=0)
        {
            // 检查胜负并更新 UI
            if (DiceNum > EneDiceNum)
            {
                WinAndLose.color = Color.red;
                WinAndLose.text = "You Win!";
                VNSceneManager.scene_manager.Start_Conversation(WinDiceAgain);
            }

            else if (DiceNum < EneDiceNum)
            {
                WinAndLose.color = Color.blue;
                WinAndLose.text = "You Lose..";
                VNSceneManager.scene_manager.Start_Conversation(LoseDiceAgain);

            }
            else
            {
                WinAndLose.color = Color.white;
                WinAndLose.text = "Try Again?";
                VNSceneManager.scene_manager.Start_Conversation(pingDiceAgain);

            }
            

                isDialogueActive = true; // 设置为对话进行中
                NumTextE.gameObject.SetActive(true); // 激活 UI
                NumTextP.gameObject.SetActive(true);


            

            // 如果 Goal 未达成，隐藏 UI
            if (DiceM.GetComponent<DiceManager>().Goal != true)
            {
                NumTextE.gameObject.SetActive(false);
                NumTextP.gameObject.SetActive(false);
            }
        }
    }

    // 重置游戏状态
    public void ResetGameState()
    {
        isDialogueActive = false; // 重置对话状态
        DiceNum = 0;  // 重置骰子点数
        EneDiceNum = 0;
        WinAndLose.text = "";  // 清除胜负文本
        NumTextE.gameObject.SetActive(false); // 隐藏 UI
        NumTextP.gameObject.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (DiceM.GetComponent<DiceManager>().Goal == true)
        {
            switch (other.name)
            {
                case "1": DiceNum += 1; break;
                case "2": DiceNum += 2; break;
                case "3": DiceNum += 3; break;
                case "4": DiceNum += 4; break;
                case "5": DiceNum += 5; break;
                case "6": DiceNum += 6; break;
                case "1E": EneDiceNum += 1; break;
                case "2E": EneDiceNum += 2; break;
                case "3E": EneDiceNum += 3; break;
                case "4E": EneDiceNum += 4; break;
                case "5E": EneDiceNum += 5; break;
                case "6E": EneDiceNum += 6; break;
            }
            Destroy(other.gameObject); // 删除已触发的骰子对象
        }
    }
}
