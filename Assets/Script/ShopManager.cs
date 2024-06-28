using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    static public int Gill=0;
    public GameObject GillNum;
    public GameObject ShopUI;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GillNum.GetComponent<Text>().text = ("Gill:"+Gill);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            ShopUI.SetActive(true);
        }
    }
    public void ShopButton_Skill1()
    {
        if (Gill >= 100)
        {
            GameObject.Find("OHS03").transform.GetComponent<Sword>().Skill1 = true;
            Gill -= 100;
           
        }

    }
    public void ShopButton_Skill2()
    {
        if (Gill >= 200)
        {
            GameObject.Find("OHS03").transform.GetComponent<Sword>().Skill2 = true;
            Gill -= 200;
        }
    }
    public void ShopButton_Skill3()
    {
        if (Gill >= 500)
        {
            GameObject.Find("OHS03").transform.GetComponent<Sword>().Skill3 = true;
            Gill -= 500;
           
        }
    }
    public void ShopButton_Return()
    {
        ShopUI.SetActive(false);
    }
}
