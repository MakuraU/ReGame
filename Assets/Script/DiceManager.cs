using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceManager : MonoBehaviour
{
    public GameObject dice;
   public bool DiceStart;
    private int rotateX;
    private int rotateY;
    private int rotateZ;
    public GameObject Hat1;
    public GameObject Hat2;
  public bool Goal;
    void Start()
    {
        DiceStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (DiceStart == true) { 
        if (Input.GetMouseButtonUp(1))
        {
            rotateX = Random.Range(0, 360);
            rotateY = Random.Range(0, 360);
            rotateZ = Random.Range(0, 360);
          
           // dice.transform.position = new Vector3(8, 8, 0);
            dice.GetComponent<Rigidbody>().AddForce(-transform.right * 300);
            dice.transform.Rotate(rotateX, rotateY, rotateZ);
        
        }
        }
    }
    public void Goaljiesuan()
    {
        Goal = true;
    }
    public void hatDes()
    {

        Hat1.SetActive(false);
        Hat2.SetActive(false);
        DiceStart = false;
        Invoke("Goaljiesuan", 2f);
    }
    public void DicegameStart()
    {
        DiceStart = true;
        Hat1.SetActive(true);
        Hat2.SetActive(true);

    }
}
