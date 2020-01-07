using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCode : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.eulerAngles=new Vector3(0,90,0);
        }
    }

    
}
