using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatManager : MonoBehaviour
{
    static public int Wood = 0;
    static public int Stone = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("MaterialUI").GetComponent<Text>().text = ("Wood"+Wood+"\nStone"+Stone);
    }
}
