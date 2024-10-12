using UnityEngine;
using VNEngine;  // ����VN Engine�������ռ�

public class CoversationCotrollerInCasino : MonoBehaviour
{
    private bool isPlayerInRange = false;
    private string NpcName;
    
    public GameObject npc1ConversationObject; // ���� ConversationManager �� GameObject
    // �����ҽ��뽻����Χ

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
            Debug.Log("��ҽ��뷶Χ�����԰�������");
        }
    }

    // �������뿪������Χ
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            Debug.Log("����뿪��Χ���޷�����");
        }
    }

    // ��Update�м�ⰴ������
    void Update()
    {
        NpcName = this.gameObject.name;
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            TriggerDialogue();
            Debug.Log("���°���");
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
