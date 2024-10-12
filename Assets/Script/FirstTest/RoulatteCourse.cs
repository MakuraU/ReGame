using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoulatteCourse : MonoBehaviour
{
     public bool orange;
     public bool green;
     public bool blue;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        
            if (other.gameObject.name == "blue")
            {
                blue = true;
            } if (other.gameObject.name == "green")
            {
                green = true;
            }if (other.gameObject.name == "orange")
            {
                orange = true;
            }
        
    }
}
