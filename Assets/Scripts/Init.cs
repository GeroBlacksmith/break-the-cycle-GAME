using Cinemachine;
using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour
{
    public GameObject player;
    public GameObject cinemachine;
    public GameObject enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        var playerInstantiate = Instantiate(player, transform.position + Vector3.right * 2, transform.rotation);
        cinemachine.GetComponent<CinemachineVirtualCamera>().Follow = playerInstantiate.transform;
        enemy.GetComponent<AIDestinationSetter>().target = playerInstantiate.transform;
        enemy.GetComponent<EnemyController>().player = player;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
