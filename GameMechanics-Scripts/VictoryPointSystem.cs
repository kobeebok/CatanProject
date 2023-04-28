using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryPointSystem : MonoBehaviour
{
    public GameManager gameManager;
    public int victoryPointsToWin = 10;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void AddVictoryPoints(int playerID, int points)
    {
        PlayerController player = gameManager.playerControllers[playerID];
        player.victoryPoints += points;

        if (player.victoryPoints >= victoryPointsToWin)
        {
            DeclareWinner(playerID);
        }
    }

    private void DeclareWinner(int playerID)
    {
        Debug.Log("Player " + (playerID + 1) + " is the bread winner!");
        
    }
}
