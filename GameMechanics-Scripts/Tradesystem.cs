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

     
    }

    public void ProposeTrade()
    {
      
    }

    public void AcceptTrade(int acceptingPlayerID)
    {
       
    }

    public void RejectTrade()
    {
        currentTradeOffer = null;
    }
}
