using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public TriggerExit trigger;
    public ScoreController score;
    public BreakTheCycle cycle;
    // Update is called once per frame
    void Update()
    {
        if (trigger.triggerExit)
        {
            StartOver();
            trigger.triggerExit = false;
            
        }
        if (cycle.breackTheCycle)
        {
            CycleBroken();
        }
          
    }

    public void StartOver()
    {
        StartCoroutine(LoadLevel(1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        // Play animation
        transition.SetTrigger("Start");
        // Wait
        score.increaseScore = true;
        yield return new WaitForSeconds(transitionTime);
        // Load Scene
        SceneManager.LoadScene(levelIndex);

    }

    public void CycleBroken()
    {
        StartCoroutine(LoadLevel(2));
    }
}
