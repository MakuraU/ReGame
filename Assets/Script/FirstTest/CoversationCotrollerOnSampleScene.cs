using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VNEngine;  // ÒıÈEN EngineµÄÃEû¿Õ¼E

public class CoversationCotrollerOnSampleScene : MonoBehaviour
{
    private bool isPlayerInRange = false;
    private string NpcName;

    public GameObject npc1ConversationObject; // °E¬ ConversationManager µÄ GameObject
                                              // ¼EâÍæ¼Ò½øÈE»»¥·¶Î§
    public GameObject shirube1ConversationObject;
    public GameObject shirube2ConversationObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
            Debug.Log("Íæ¼Ò½øÈE¶Î§£¬¿ÉÒÔ°´¼E»»¥");
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
        if (NpcName == "ZahuoShop")
        {
            // ¼ÙÉèÄãÒÑÉèÖÃºÃ¶Ô»°¿òºÍ¶Ô»°ÄÚÈİ£¬¿ÉÒÔÍ¨¹ıVNEngineµÄAPIÀ´Æô¶¯¶Ô»°
            VNSceneManager.scene_manager.Start_Conversation(npc1ConversationObject);  // µ÷ÓÃVisual Novel EngineµÄ¶Ô»°Æô¶¯º¯Êı
            Debug.Log("¶Ô»°¿ªÊ¼");
        }
        if (NpcName == "shirube1")
        {
            // ¼ÙÉèÄãÒÑÉèÖÃºÃ¶Ô»°¿òºÍ¶Ô»°ÄÚÈİ£¬¿ÉÒÔÍ¨¹ıVNEngineµÄAPIÀ´Æô¶¯¶Ô»°
            VNSceneManager.scene_manager.Start_Conversation(shirube1ConversationObject);  // µ÷ÓÃVisual Novel EngineµÄ¶Ô»°Æô¶¯º¯Êı
            Debug.Log("¶Ô»°¿ªÊ¼");
        }
        if (NpcName == "shirube2")
        {
            // ¼ÙÉèÄãÒÑÉèÖÃºÃ¶Ô»°¿òºÍ¶Ô»°ÄÚÈİ£¬¿ÉÒÔÍ¨¹ıVNEngineµÄAPIÀ´Æô¶¯¶Ô»°
            VNSceneManager.scene_manager.Start_Conversation(shirube2ConversationObject);  // µ÷ÓÃVisual Novel EngineµÄ¶Ô»°Æô¶¯º¯Êı
            Debug.Log("¶Ô»°¿ªÊ¼");
        }
    }
    public void GillMinus()
    {
        GillManager.Gill -= 100;
    }
}
