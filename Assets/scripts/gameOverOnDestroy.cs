using UnityEngine;
using System.Collections;

public class gameOverOnDestroy : MonoBehaviour
{
    void OnDestroy ()
    {
        GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        gameManager.gameOver = true;
    }
}
