using System.Collections.Generic;
using UnityEngine;

public class AIPlayerController : PlayerController
{
    public float decisionDelay = 2f;

    private GameManager gameManager;
    private UIManager uiManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        uiManager = FindObjectOfType<UIManager>();
    }

    public override void BeginTurn()
    {
        base.BeginTurn();
        StartCoroutine(AIMakeDecision());
    }

    private IEnumerator AIMakeDecision()
    {
        
        yield return new WaitForSeconds(decisionDelay);

      
        if (CanBuildSettlement())
        {
            
        }
        else if (CanBuildCity())
        {
            
        }
        else if (CanBuildRoad())
        {
            
        }

        
    }

    private bool CanBuildSettlement()
    {
        }

    private bool CanBuildCity()
    {
    }

    private bool CanBuildRoad()
    {
    }
}
