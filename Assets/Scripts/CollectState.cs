using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectState : IState<EnemyCharacter>
{
    public void OnEnter(EnemyCharacter t)
    {
        t.SetTarget();
    }

    public void OnExecute(EnemyCharacter t)
    {
        t.MoveToTarget();
        if()
    }

    public void OnExit(EnemyCharacter t)
    {

    }
    

}