using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalityControllerOnVN : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void T(){

        PersonalityParamater.TF -= 10;
    }  public void F(){

        PersonalityParamater.TF += 10;
    } public void P(){

        PersonalityParamater.PJ -= 10;
    }public void J(){

        PersonalityParamater.PJ += 10;
    }public void C(){

        PersonalityParamater.CH -= 10;
    }public void H(){

        PersonalityParamater.CH += 10;
    }
}
