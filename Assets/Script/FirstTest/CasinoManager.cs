using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasinoManager : MonoBehaviour
{
    public GameObject DiceGameTable;
    public GameObject Roulatte;
    public GameObject MiniGameCamera;
    static public bool DiceEnd;
    void Start()
    {
        
    }

    public void DiceGameO()
    {

        DiceEnd = true;
        MiniGameCamera.SetActive(false);

    } 
    void Update()
    {
        
    }
    public void DiceGameSet()
    {
        DiceEnd = false;
        Vector3 position = new Vector3(16f, 5f, 0);
        Instantiate(DiceGameTable, position, Quaternion.identity);
        MiniGameCamera.SetActive(true);
       
    }
    public void RoulatteGameSet()
    {
        Vector3 position = new Vector3(16f, 5f, 0);
        Instantiate(Roulatte, position, Quaternion.identity);
        MiniGameCamera.SetActive(true);
    }
}
