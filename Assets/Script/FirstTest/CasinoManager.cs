using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasinoManager : MonoBehaviour
{
    public GameObject DiceGameTable;
    public GameObject Roulatte;
    public GameObject MiniGameCamera;
   public bool DiceEnd;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    public void DiceGameDestroy()
    {
        GameObject oldDiceGameTable = GameObject.FindWithTag("DiceGameTable");
        if (oldDiceGameTable != null)
        {
            Destroy(oldDiceGameTable);
        }
        MiniGameCamera.SetActive(false);
    }
    public void DiceGameSet()
    {
        DiceEnd = false;

        // ����ɵ� DiceGameTable ����
        GameObject oldDiceGameTable = GameObject.FindWithTag("DiceGameTable");
        if (oldDiceGameTable != null)
        {
            Destroy(oldDiceGameTable);
        }

        Vector3 position = new Vector3(16f, 5f, 0);
        GameObject newTable = Instantiate(DiceGameTable, position, Quaternion.identity);
        newTable.tag = "DiceGameTable";  // ���¶�����ӱ�ǩ
        MiniGameCamera.SetActive(true);
       
    }
    public void RoulatteGameSet()
    {
        Vector3 position = new Vector3(16f, 5f, 0);
        Instantiate(Roulatte, position, Quaternion.identity);
        MiniGameCamera.SetActive(true);
    }
}
