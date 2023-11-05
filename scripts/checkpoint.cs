using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public GameObject checkpointmanager;
    private checkpointmanager cm;
    private void Start()
    {
        cm = checkpointmanager.GetComponent<checkpointmanager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        
           cm.reached = true;
          //  Debug.Log("hit");
        
    }
 
}
