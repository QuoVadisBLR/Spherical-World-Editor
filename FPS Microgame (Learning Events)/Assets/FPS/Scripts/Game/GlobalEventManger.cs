using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GlobalEventManger
{
    public static UnityEvent<int> OnEnemyKilled = new UnityEvent<int>();

    public static void SendEnemyKilled(int enemiesRemaining)
    {
            OnEnemyKilled.Invoke(enemiesRemaining);
    }

}
