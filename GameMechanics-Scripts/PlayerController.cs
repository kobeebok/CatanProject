using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerID;
    public int victoryPoints;
    public int resourcesInHand;

    private GameManager gameManager;
    private UIManager uiManager;
    private TradeSystem tradeSystem;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        uiManager = FindObjectOfType<UIManager>();
        tradeSystem = FindObjectOfType<TradeSystem>();
    }

    void Update()
    {
        if (gameManager.currentPlayerID == playerID)
        {
        
        }
        }
    }

    private void RollDice()
    {
        gameManager.RollDice();
    }

    public void BuildSettlement()
    {
        gameManager.BuildSettlement(playerID);
    }

    public void BuildCity()
    {
        gameManager.BuildCity(playerID);
    }

    public void BuildRoad()
    {
        gameManager.BuildRoad(playerID);
    }

    public void BuyDevelopmentCard()
    {
        gameManager.BuyDevelopmentCard(playerID);
    }

    public void InitiateTrade()
    {
        tradeSystem.InitiateTrade(playerID);
    }
}