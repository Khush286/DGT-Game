using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CoreGame : MonoBehaviour
{
    public Player player;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Player p = new Player();
        Instantiate(p, transform.position, transform.rotation);
    }


}
