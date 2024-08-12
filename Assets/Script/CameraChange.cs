using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraChange : MonoBehaviour
{
    public GameObject TopCamera;
    private bool tD;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (tD == false)
            {
                TopCamera.SetActive(true);
                tD = true;
            }
            
        }
    }
}
