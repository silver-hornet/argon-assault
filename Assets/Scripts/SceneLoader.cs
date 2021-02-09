using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] float loadDelay = 2f;

    void Start()
    {
        Invoke("LoadFirstScene", loadDelay);
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}