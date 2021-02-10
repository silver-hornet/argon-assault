using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // ok, as long as this is the only script that loads scenes

public class CollisionHandler : MonoBehaviour
{
    [Tooltip("In seconds")][SerializeField] GameObject deathFX;
    [Tooltip("FX prefab on player")][SerializeField] float levelLoadDelay = 1f;

    void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
    }

    void StartDeathSequence()
    {
        print("Player dying");
        SendMessage("OnPlayerDeath");
        deathFX.SetActive(true);
        Invoke("ReloadScene", levelLoadDelay);
    }

    void ReloadScene() // string referenced
    {
        SceneManager.LoadScene(1);
    }
}