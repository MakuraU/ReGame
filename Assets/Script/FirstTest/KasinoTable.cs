using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VNEngine;
public class KasinoTable : MonoBehaviour
{
    public float DiceNum;
    public float EneDiceNum;
    public Text NumTextP; // ֱ������ Text ���
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
        // ʼ�ո��� UI �ı�
        NumTextP.text = DiceNum.ToString();
        NumTextE.text = EneDiceNum.ToString();
        Debug.Log($"DiceNum: {DiceNum}, EneDiceNum: {EneDiceNum}, Goal: {DiceM.GetComponent<DiceManager>().Goal}");

        // ��� Goal ��ɣ���ʼ����ʤ�����
        if (DiceM.GetComponent<DiceManager>().Goal == true && !isDialogueActive &&DiceNum!=0)
        {
            // ���ʤ�������� UI
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
            

                isDialogueActive = true; // ����Ϊ�Ի�������
                NumTextE.gameObject.SetActive(true); // ���� UI
                NumTextP.gameObject.SetActive(true);


            

            // ��� Goal δ��ɣ����� UI
            if (DiceM.GetComponent<DiceManager>().Goal != true)
            {
                NumTextE.gameObject.SetActive(false);
                NumTextP.gameObject.SetActive(false);
            }
        }
    }

    // ������Ϸ״̬
    public void ResetGameState()
    {
        isDialogueActive = false; // ���öԻ�״̬
        DiceNum = 0;  // �������ӵ���
        EneDiceNum = 0;
        WinAndLose.text = "";  // ���ʤ���ı�
        NumTextE.gameObject.SetActive(false); // ���� UI
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
            Destroy(other.gameObject); // ɾ���Ѵ��������Ӷ���
        }
    }
}
