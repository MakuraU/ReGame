using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public GameObject Canava1;
    public GameObject Canava2;
   static public float TimeToName = 0f; // �U�^�r�g
    static public bool Named =false;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

      
        if (Named == true)
        {
            // �U�^�r�g�����
            TimeToName += Time.deltaTime;
            //Debug.Log(TimeToName);
        }
    }
    public void StartButton()
    {

        Canava1.SetActive(false);
        Canava2.SetActive(true);
        GameObject.Find("InputField").GetComponent<InputField>().text="����̫��";
        Named = true;
    
    }
    public void NamedToStart()
    {

        SceneManager.LoadScene("StartScenev0");


    }

}
