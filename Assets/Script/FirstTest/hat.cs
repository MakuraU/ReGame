using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hat : MonoBehaviour
{
    public GameObject Hat1; 
    public GameObject Hat2;
    static public bool Goal;
    void Start()
    {
        
    }
    public void hatDes ()
    {
        
        Hat1.SetActive(false);
        Hat2.SetActive(false);
        DiceManager.DiceStart = false;
        Invoke("Goaljiesuan", 3f);
    }
    public void Goaljiesuan()
    {
        Goal = true;
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
