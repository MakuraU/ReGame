using UnityEngine;
using VNEngine;  // ÒıÈEN EngineµÄÃEû¿Õ¼E

public class CoversationCotrollerInCasino : MonoBehaviour
{
    private bool isPlayerInRange = false;
    private string NpcName;
    
    public GameObject npc1ConversationObject; // °E¬ ConversationManager µÄ GameObject
    // ¼EâÍæ¼Ò½øÈE»»¥·¶Î§

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
         
        }
    }

    // ¼EâÍæ¼ÒÀEª½»»¥·¶Î§
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            Debug.Log("Íæ¼ÒÀEª·¶Î§£¬ÎŞ·¨½»»¥");
        }
    }

    // ÔÚUpdateÖĞ¼Eâ°´¼E´ÏÂ
    void Update()
    {
        NpcName = this.gameObject.name;
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            TriggerDialogue();
          
        }
    }

    // Æô¶¯¶Ô»°
    void TriggerDialogue()
    {
        if (NpcName == "Npc1")
        {
            // ¼ÙÉèÄãÒÑÉèÖÃºÃ¶Ô»°¿òºÍ¶Ô»°ÄÚÈİ£¬¿ÉÒÔÍ¨¹ıVNEngineµÄAPIÀ´Æô¶¯¶Ô»°
            VNSceneManager.scene_manager.Start_Conversation(npc1ConversationObject);  // µ÷ÓÃVisual Novel EngineµÄ¶Ô»°Æô¶¯º¯Êı
            Debug.Log("¶Ô»°¿ªÊ¼");
        }
        }
    }
