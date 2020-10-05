using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Player(Clone)")
        {
            Debug.Log("DIE!");
            collision.gameObject.GetComponent<PlayerController>().Die();
        }
    }
    
}
