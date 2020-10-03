using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExit : MonoBehaviour
{
    public bool triggerExit = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        triggerExit = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
