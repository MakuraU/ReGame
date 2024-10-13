using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GillManager : MonoBehaviour
{
    static public int Gill = 0;
    public GameObject GillNum;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GillNum.GetComponent<Text>().text = ("Gill:" + Gill);
    }
    
}
