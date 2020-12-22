using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Enemies : MonoBehaviour
{


    public GameObject TheBurst;
    public GameObject TheBuzzSaw;
    public GameObject TheDashSaw;

    public enum State { TheBurst, TheBuzzSaw, ThDashSaw }

    public State EnemyType;

    public GameObject[] EnemyArray;
    public int numSelectors = 5;


    // Start is called before the first frame update
    void Start()
    {
        if (EnemyType == State.TheBurst)
        {
            EnemyArray = new GameObject[numSelectors];
            for (int i = 0; i < numSelectors; i++)
            {
                GameObject BurstEnemy = Instantiate(TheBurst, new Vector3((float)i, 1, 0), Quaternion.identity) as GameObject;
                BurstEnemy.transform.localScale = Vector3.one;
                EnemyArray[i] = BurstEnemy;
                BurstEnemy.SetActive(false); 
                
            }
        }
        else if (EnemyType == State.TheBuzzSaw)
        {

        }
        else if (EnemyType == State.ThDashSaw)
        {

        }





    }


    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnEnemies(State enemytype)
    {
        //EnemyType == enemytype;  
    }
}
