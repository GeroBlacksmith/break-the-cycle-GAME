using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakTheCycle : MonoBehaviour
{
    public bool breackTheCycle = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        breackTheCycle = true;
    }
}
