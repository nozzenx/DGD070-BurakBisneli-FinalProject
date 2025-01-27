using System;
using UnityEngine;
using TMPro;
using UnityEngine.Serialization;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    
    [SerializeField] GameObject playButton;
    [SerializeField] private GameObject aWinrarIsYou;
    
    public bool pauseGame;
    
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        pauseGame = true;
    }

    public void PauseGame()
    {
        pauseGame = true;
    }

    public void StartGame()
    {
        pauseGame = false;
        playButton.SetActive(false);
    }

    public void GameOver()
    {
        PauseGame();
        aWinrarIsYou.SetActive(true);
    }
    
}
