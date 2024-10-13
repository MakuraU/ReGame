using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    
    
    public GameObject ShopUI;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
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
        if (GillManager.Gill >= 100)
        {
            GameObject.Find("OHS03").transform.GetComponent<Sword>().Skill1 = true;
            GillManager.Gill -= 100;
           
        }

    }
    public void ShopButton_Skill2()
    {
        if (GillManager.Gill >= 200)
        {
            GameObject.Find("OHS03").transform.GetComponent<Sword>().Skill2 = true;
            GillManager.Gill -= 200;
        }
    }
    public void ShopButton_Skill3()
    {
        if (GillManager.Gill >= 500)
        {
            GameObject.Find("OHS03").transform.GetComponent<Sword>().Skill3 = true;
            GillManager.Gill -= 500;
           
        }
    }
    public void ShopButton_Return()
    {
        ShopUI.SetActive(false);
    }
}
