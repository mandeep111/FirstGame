using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManageer : MonoBehaviour
{
    public Player player;
    public ScoreManager scoreManager;
    public AudioSource backgroundSound;
    public AudioSource deathSound;
    private Vector3 playerStartingPoint;
    private Vector3 groundGeneratingStartPoint;
    public GroundGenerator groundGenerator;
    public GameObject largeGround;
    public GameObject mediumGround;
    public GameObject gameOverScreen;

    void Start()
    {
        playerStartingPoint = player.transform.position;
        groundGeneratingStartPoint = groundGenerator.transform.position;
        gameOverScreen.SetActive(false);
    }

    // void GameOver() {
    //     gameOverScreen.SetActive(true);
    //     scoreManager.isScoreIncreasing = false;
    // }
    void Quit() {

    }
    void Restart() {

    }
}
