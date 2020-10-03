using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private static int score = 0;
    public bool increaseScore = false;
    public GameObject breakableObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (increaseScore)
        {
            score++;
            increaseScore = false;
            Debug.Log(score);
        }
        if (score > 4)
        {
            DestroyObject(breakableObject);
        }
    }

    void DestroyObject(GameObject go)
    {
        Destroy(go);
    }
}
