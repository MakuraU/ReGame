using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VNEngine;  // 引入VN Engine的命名空间

public class CoversationCotrollerOnSampleScene : MonoBehaviour
{
    private bool isPlayerInRange = false;
    private string NpcName;

    public GameObject npc1ConversationObject; // 包含 ConversationManager 的 GameObject
                                              // 检测玩家进入交互范围
    public GameObject shirube1ConversationObject;
    public GameObject shirube2ConversationObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
            Debug.Log("玩家进入范围，可以按键交互");
        }
    }

    // 检测玩家离开交互范围
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            Debug.Log("玩家离开范围，无法交互");
        }
    }

    // 在Update中检测按键按下
    void Update()
    {
        NpcName = this.gameObject.name;
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            TriggerDialogue();
            Debug.Log("按下按键");
        }
    }

    // 启动对话
    void TriggerDialogue()
    {
        if (NpcName == "ZahuoShop")
        {
            // 假设你已设置好对话框和对话内容，可以通过VNEngine的API来启动对话
            VNSceneManager.scene_manager.Start_Conversation(npc1ConversationObject);  // 调用Visual Novel Engine的对话启动函数
            Debug.Log("对话开始");
        }
        if (NpcName == "shirube1")
        {
            // 假设你已设置好对话框和对话内容，可以通过VNEngine的API来启动对话
            VNSceneManager.scene_manager.Start_Conversation(shirube1ConversationObject);  // 调用Visual Novel Engine的对话启动函数
            Debug.Log("对话开始");
        }
        if (NpcName == "shirube2")
        {
            // 假设你已设置好对话框和对话内容，可以通过VNEngine的API来启动对话
            VNSceneManager.scene_manager.Start_Conversation(shirube2ConversationObject);  // 调用Visual Novel Engine的对话启动函数
            Debug.Log("对话开始");
        }
    }
    public void GillMinus()
    {
        GillManager.Gill -= 100;
    }
}
