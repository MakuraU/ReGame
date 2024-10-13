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
        if (Title.TimeToName >= 10)
        {
            PersonalityParameterOnBigFive.ActivityLevel -= 2;
        }
        if (Title.TimeToName >= 15)
        {
            PersonalityParameterOnBigFive.ActivityLevel -= 5;
        }


        EditorSceneManager.LoadScene("StartScene");
    }

    public void GetInputNameToStart()

    {

    }
}