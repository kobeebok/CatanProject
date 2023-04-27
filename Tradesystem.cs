using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TradeSystem : MonoBehaviour
{
    public GameManager gameManager;

    public class TradeOffer
    {
        public int playerID;
    }

    private TradeOffer currentTradeOffer;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void InitiateTrade(int playerID)
    {
        currentTradeOffer = new TradeOffer();
        currentTradeOffer.playerID = playerID;

        // Show the trade UI for the current player to input their trade offer

    }

    public void ProposeTrade()
    {
        // Show the trade UI for other players to accept or reject the trade offer
    }

    public void AcceptTrade(int acceptingPlayerID)
    {
       
    }

    public void RejectTrade()
    {
        currentTradeOffer = null;
    }
}