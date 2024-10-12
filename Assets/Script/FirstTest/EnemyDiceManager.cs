using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDiceManager : MonoBehaviour
{
    private int rotateX;
    private int rotateY;
    private int rotateZ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    public void EneDice()
    {
        rotateX = Random.Range(0, 360);
        rotateY = Random.Range(0, 360);
        rotateZ = Random.Range(0, 360);

        // dice.transform.position = new Vector3(8, 8, 0);
        this.gameObject.GetComponent<Rigidbody>().AddForce(-transform.right * 300);
        this.gameObject.transform.Rotate(rotateX, rotateY, rotateZ);

    }
}
