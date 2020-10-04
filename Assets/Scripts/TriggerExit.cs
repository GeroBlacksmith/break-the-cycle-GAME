using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExit : MonoBehaviour
{
    public bool triggerExit = false;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        triggerExit = true;
    }

   
}
