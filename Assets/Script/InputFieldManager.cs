using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
 
public class InputFieldManager : MonoBehaviour
{
    //InputField
    InputField inputField;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
      
    }



    public void GetInputName()
       
    {
        
        inputField = GameObject.Find("InputField").GetComponent<InputField>();
       
        string playerName = inputField.text;
        gameManager.PlayerName = playerName;
        Title.Named = false;
        if (Title.TimeToName >=15)
        {
            PersonalityParamater.TF += 10;
        }
        else if (Title.TimeToName >= 30)
        {
            PersonalityParamater.TF += 20;
        }
        if (playerName == "H‰È‘¾˜Y")
        {
            PersonalityParamater.TF -= 15;
            if ( Title.TimeToName <= 10)
            {
                PersonalityParamater.TF -= 25;
            }
        }
        else
        {
            PersonalityParamater.TF += 10;
        }
        EditorSceneManager.LoadScene("StartScene");
    }

    public void GetInputNameToStart()

    {
        //InputField¥³¥ó¥İ©`¥Í¥ó¥È¤òÈ¡µÃ
        inputField = GameObject.Find("InputField").GetComponent<InputField>();
        
        string playerName = inputField.text;
        gameManager.PlayerName = playerName;
        Title.Named = false;
        if (Title.TimeToName >= 15)
        {
            PersonalityParamater.TF += 15;
        }
        else if (Title.TimeToName >= 30)
        {
            PersonalityParamater.TF += 25;
        }
        if (playerName == "H‰È‘¾˜Y")
        {
            PersonalityParamater.TF -= 10;
            if (Title.TimeToName <= 10)
            {
                PersonalityParamater.TF -= 30;
            }
        }
        if (playerName != "H‰È‘¾˜Y")
        {
            PersonalityParamater.TF += 10;
           
        }
        PersonalityParamater.CH -= 10;
        Debug.Log(name);
        EditorSceneManager.LoadScene("StartScene");
    }
}