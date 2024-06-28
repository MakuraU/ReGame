using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    private GameObject Playerob;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Playerob = GameObject.Find("Player");
        this.gameObject.GetComponent<CinemachineVirtualCamera>().Follow = Playerob.transform;
     
         
    
    
    }
}
