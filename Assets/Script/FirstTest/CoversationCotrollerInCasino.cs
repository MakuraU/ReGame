using UnityEngine;
using VNEngine;  // ��ȁEN Engine��ÁE��ռ�E

public class CoversationCotrollerInCasino : MonoBehaviour
{
    private bool isPlayerInRange = false;
    private string NpcName;
    
    public GameObject npc1ConversationObject; // ��E� ConversationManager �� GameObject
    // ��E���ҽ�ȁE�����Χ

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
         
        }
    }

    // ��E������E�������Χ
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            Debug.Log("�����E���Χ���޷�����");
        }
    }

    // ��Update�м�Eⰴ��E���
    void Update()
    {
        NpcName = this.gameObject.name;
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            TriggerDialogue();
          
        }
    }

    // �����Ի�
    void TriggerDialogue()
    {
        if (NpcName == "Npc1")
        {
            // �����������úöԻ���ͶԻ����ݣ�����ͨ��VNEngine��API�������Ի�
            VNSceneManager.scene_manager.Start_Conversation(npc1ConversationObject);  // ����Visual Novel Engine�ĶԻ���������
            Debug.Log("�Ի���ʼ");
        }
        }
    }
