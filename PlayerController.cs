using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public float targetX;
    private void Update()
    {
        //var targetPosition = transform.position;

        //targetPosition += transform.forward / 100f;

        transform.Translate(0,0,2*Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-29*Time.deltaTime,0,0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(29 * Time.deltaTime, 0, 0);
        }

       

        //targetPosition.x = Mathf.MoveTowards(targetPosition.x, targetX, 1*Time.deltaTime);

        //transform.position = targetPosition;
    }

}