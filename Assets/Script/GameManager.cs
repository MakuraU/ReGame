using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
     public string PlayerName;
    public int GameEndTime = 0;
    public bool Ending=false;
    void Start()
    {
        // ���`���w����Ᵽ��
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameEndTime >= 100) {


            Ending = true;
        
        }

        if (Ending == true)
        {
            Debug.Log("Ending");
        }
    }
}
