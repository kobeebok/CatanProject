using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int currentPlayerID = 0;
    public int numberOfPlayers = 4;
    public List<PlayerController> playerControllers;
    public BoardManager boardManager;

    public UIManager uiManager;
    public TradeSystem tradeSystem;

    public VictoryPointSystem victoryPointSystem;

    public int minDiceRoll = 2;
    public int maxDiceRoll = 12;
   

    void Start()
    {
        boardManager = FindObjectOfType<BoardManager>();
        victoryPointSystem = FindObjectOfType<VictoryPointSystem>();
        uiManager = FindObjectOfType<UIManager>();
        tradeSystem = FindObjectOfType<TradeSystem>();

        InitializePlayers();
    }

    void InitializePlayers()
    {
        playerControllers = new List<PlayerController>();

        for (int i = 0; i < numberOfPlayers; i++)
        {
            GameObject playerObject = new GameObject("Player" + (i + 1));
            PlayerController playerController = playerObject.AddComponent<PlayerController>();
            playerController.playerID = i;
            playerControllers.Add(playerController);
        }
    }

    public void RollDice()
    {
       
    }

    public void BuildSettlement(int playerID)
    {
       
         victoryPointSystem.AddVictoryPoints(playerID, 1);
    }

    public void BuildCity(int playerID)
    {
        /
          victoryPointSystem.AddVictoryPoints(playerID, 1);
    }

    public void BuildRoad(int playerID)
    {
        
    }

    public void BuyDevelopmentCard(int playerID)
    {
       
    }

    public void InitiateTrade(int playerID)
    {
        tradeSystem.InitiateTrade(playerID);
    }
    
    void NextTurn()
    {
      
    }
}
