using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KilledText : MonoBehaviour
{
    private int killed = 0;
    private void Start()
    {
        GlobalEventManger.OnEnemyKilled.AddListener(KilledEnemy);
    }

    private void KilledEnemy(int enemiesRemaining)
    {
        killed++;
        GetComponent<TMP_Text>().text = "Killed: " + killed + " Remaining" + enemiesRemaining ;
    }
    
}
