    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
        SceneManager.sceneLoaded += LoadState;
        DontDestroyOnLoad(gameObject);
    }

    public Player player;
    public int Lives;
    public void SaveState()
    {



    }

    public void LoadState(Scene s, LoadSceneMode mode)
    {



    }
}
