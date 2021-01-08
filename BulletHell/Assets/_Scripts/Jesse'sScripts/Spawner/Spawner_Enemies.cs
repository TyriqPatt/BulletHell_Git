using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Enemies : MonoBehaviour
{

    public GameObject[] Enemies;
    public GameObject[] Spawners;
    
    public AddRooms parentRoom;


    // Start is called before the first frame update
    void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
             
        }
    }

    public void spawnWave()
    {
        //Spawns a random enemy on all spawners at the same time
        SpawnEnemiesOnce();
        //Spawn random enemies over time on one spawner
        SpawnEnemiesOverTime();
        this.enabled = false;
    }

    public void SpawnEnemiesOnce()
    {
        //Selecting random enemy for spawner 0
        int rand0;
        rand0 = Random.Range(0, 4);
        //placing randomly selected dash enemy at spawn 0 location
        if (rand0 == 0)
        {
            for (int i = 0; i < ObjectPooling.Instance.DashEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.DashEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.DashEnemList[i].SetActive(true);
                    ObjectPooling.Instance.DashEnemList[i].transform.position = Spawners[0].transform.position;
                    ObjectPooling.Instance.DashEnemList[i].transform.rotation = Spawners[0].transform.rotation;
                    break;
                }
            }
        }
        //placing randomly selected buzz enemy at spawn 0 location
        else if (rand0 == 1)
        {
            for (int i = 0; i < ObjectPooling.Instance.BuzzEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.BuzzEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.BuzzEnemList[i].SetActive(true);
                    ObjectPooling.Instance.BuzzEnemList[i].transform.position = Spawners[0].transform.position;
                    ObjectPooling.Instance.BuzzEnemList[i].transform.rotation = Spawners[0].transform.rotation;
                    break;
                }
            }
        }
        //placing randomly selected burst enemy at spawn 0 location
        else if (rand0 == 2)
        {
            for (int i = 0; i < ObjectPooling.Instance.BurstEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.BurstEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.BurstEnemList[i].SetActive(true);
                    ObjectPooling.Instance.BurstEnemList[i].transform.position = Spawners[0].transform.position;
                    ObjectPooling.Instance.BurstEnemList[i].transform.rotation = Spawners[0].transform.rotation;
                    break;
                }
            }
        }
        //placing randomly selected shotgun enemy at spawn 0 location
        else if (rand0 == 3)
        {
            for (int i = 0; i < ObjectPooling.Instance.ShotgunEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.ShotgunEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.ShotgunEnemList[i].SetActive(true);
                    ObjectPooling.Instance.ShotgunEnemList[i].transform.position = Spawners[0].transform.position;
                    ObjectPooling.Instance.ShotgunEnemList[i].transform.rotation = Spawners[0].transform.rotation;
                    break;
                }
            }
        }

        //Selecting random enemy for spawner 1
        int rand1;
        rand1 = Random.Range(0, 4);
        //placing randomly selected dash enemy at spawn 1 location
        if (rand1 == 0)
        {
            for (int i = 0; i < ObjectPooling.Instance.DashEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.DashEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.DashEnemList[i].SetActive(true);
                    ObjectPooling.Instance.DashEnemList[i].transform.position = Spawners[1].transform.position;
                    ObjectPooling.Instance.DashEnemList[i].transform.rotation = Spawners[1].transform.rotation;
                    break;
                }
            }
        }
        //placing randomly selected buzz enemy at spawn 1 location
        else if (rand1 == 1)
        {
            for (int i = 0; i < ObjectPooling.Instance.BuzzEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.BuzzEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.BuzzEnemList[i].SetActive(true);
                    ObjectPooling.Instance.BuzzEnemList[i].transform.position = Spawners[1].transform.position;
                    ObjectPooling.Instance.BuzzEnemList[i].transform.rotation = Spawners[1].transform.rotation;
                    break;
                }
            }
        }
        //placing randomly selected burst enemy at spawn 1 location
        else if (rand1 == 2)
        {
            for (int i = 0; i < ObjectPooling.Instance.BurstEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.BurstEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.BurstEnemList[i].SetActive(true);
                    ObjectPooling.Instance.BurstEnemList[i].transform.position = Spawners[1].transform.position;
                    ObjectPooling.Instance.BurstEnemList[i].transform.rotation = Spawners[1].transform.rotation;
                    break;
                }
            }
        }
        //placing randomly selected shotgun enemy at spawn 1 location
        else if (rand1 == 3)
        {
            for (int i = 0; i < ObjectPooling.Instance.ShotgunEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.ShotgunEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.ShotgunEnemList[i].SetActive(true);
                    ObjectPooling.Instance.ShotgunEnemList[i].transform.position = Spawners[1].transform.position;
                    ObjectPooling.Instance.ShotgunEnemList[i].transform.rotation = Spawners[1].transform.rotation;
                    break;
                }
            }
        }

        //Selecting random enemy for spawner 2
        int rand2;
        rand2 = Random.Range(0, 4);
        //placing randomly selected dash enemy at spawn 2 location
        if (rand2 == 0)
        {
            for (int i = 0; i < ObjectPooling.Instance.DashEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.DashEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.DashEnemList[i].SetActive(true);
                    ObjectPooling.Instance.DashEnemList[i].transform.position = Spawners[2].transform.position;
                    ObjectPooling.Instance.DashEnemList[i].transform.rotation = Spawners[2].transform.rotation;
                    break;
                }
            }
        }
        //placing randomly selected buzz enemy at spawn 2 location
        else if (rand2 == 1)
        {
            for (int i = 0; i < ObjectPooling.Instance.BuzzEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.BuzzEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.BuzzEnemList[i].SetActive(true);
                    ObjectPooling.Instance.BuzzEnemList[i].transform.position = Spawners[2].transform.position;
                    ObjectPooling.Instance.BuzzEnemList[i].transform.rotation = Spawners[2].transform.rotation;
                    break;
                }
            }
        }
        //placing randomly selected burst enemy at spawn 2 location
        else if (rand2 == 2)
        {
            for (int i = 0; i < ObjectPooling.Instance.BurstEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.BurstEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.BurstEnemList[i].SetActive(true);
                    ObjectPooling.Instance.BurstEnemList[i].transform.position = Spawners[2].transform.position;
                    ObjectPooling.Instance.BurstEnemList[i].transform.rotation = Spawners[2].transform.rotation;
                    break;
                }
            }
        }
        //placing randomly selected shotgun enemy at spawn 2 location
        else if (rand2 == 3)
        {
            for (int i = 0; i < ObjectPooling.Instance.ShotgunEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.ShotgunEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.ShotgunEnemList[i].SetActive(true);
                    ObjectPooling.Instance.ShotgunEnemList[i].transform.position = Spawners[2].transform.position;
                    ObjectPooling.Instance.ShotgunEnemList[i].transform.rotation = Spawners[2].transform.rotation;
                    break;
                }
            }
        }

        //Selecting random enemy for spawner 3
        int rand3;
        rand3 = Random.Range(0, 4);
        //placing randomly selected dash enemy at spawn 3 location
        if (rand3 == 0)
        {
            for (int i = 0; i < ObjectPooling.Instance.DashEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.DashEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.DashEnemList[i].SetActive(true);
                    ObjectPooling.Instance.DashEnemList[i].transform.position = Spawners[3].transform.position;
                    ObjectPooling.Instance.DashEnemList[i].transform.rotation = Spawners[3].transform.rotation;
                    break;
                }
            }
        }
        //placing randomly selected buzz enemy at spawn 3 location
        else if (rand3 == 1)
        {
            for (int i = 0; i < ObjectPooling.Instance.BuzzEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.BuzzEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.BuzzEnemList[i].SetActive(true);
                    ObjectPooling.Instance.BuzzEnemList[i].transform.position = Spawners[3].transform.position;
                    ObjectPooling.Instance.BuzzEnemList[i].transform.rotation = Spawners[3].transform.rotation;
                    break;
                }
            }
        }
        //placing randomly selected burst enemy at spawn 3 location
        else if (rand3 == 2)
        {
            for (int i = 0; i < ObjectPooling.Instance.BurstEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.BurstEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.BurstEnemList[i].SetActive(true);
                    ObjectPooling.Instance.BurstEnemList[i].transform.position = Spawners[3].transform.position;
                    ObjectPooling.Instance.BurstEnemList[i].transform.rotation = Spawners[3].transform.rotation;
                    break;
                }
            }
        }
        //placing randomly selected shotgun enemy at spawn 3 location
        else if (rand3 == 3)
        {
            for (int i = 0; i < ObjectPooling.Instance.ShotgunEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.ShotgunEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.ShotgunEnemList[i].SetActive(true);
                    ObjectPooling.Instance.ShotgunEnemList[i].transform.position = Spawners[3].transform.position;
                    ObjectPooling.Instance.ShotgunEnemList[i].transform.rotation = Spawners[3].transform.rotation;
                    break;
                }
            }
        }

        //Selecting random enemy for spawner 4
        int rand4;
        rand4 = Random.Range(0, 4);
        //placing randomly selected dash enemy at spawn 4 location
        if (rand4 == 0)
        {
            for (int i = 0; i < ObjectPooling.Instance.DashEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.DashEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.DashEnemList[i].SetActive(true);
                    ObjectPooling.Instance.DashEnemList[i].transform.position = Spawners[4].transform.position;
                    ObjectPooling.Instance.DashEnemList[i].transform.rotation = Spawners[4].transform.rotation;
                    break;
                }
            }
        }
        //placing randomly selected buzz enemy at spawn 4 location
        else if (rand4 == 1)
        {
            for (int i = 0; i < ObjectPooling.Instance.BuzzEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.BuzzEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.BuzzEnemList[i].SetActive(true);
                    ObjectPooling.Instance.BuzzEnemList[i].transform.position = Spawners[4].transform.position;
                    ObjectPooling.Instance.BuzzEnemList[i].transform.rotation = Spawners[4].transform.rotation;
                    break;
                }
            }
        }
        //placing randomly selected burst enemy at spawn 4 location
        else if (rand4 == 2)
        {
            for (int i = 0; i < ObjectPooling.Instance.BurstEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.BurstEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.BurstEnemList[i].SetActive(true);
                    ObjectPooling.Instance.BurstEnemList[i].transform.position = Spawners[4].transform.position;
                    ObjectPooling.Instance.BurstEnemList[i].transform.rotation = Spawners[4].transform.rotation;
                    break;
                }
            }
        }
        //placing randomly selected shotgun enemy at spawn 4 location
        else if (rand4 == 3)
        {
            for (int i = 0; i < ObjectPooling.Instance.ShotgunEnemList.Count; i++)
            {
                if (ObjectPooling.Instance.ShotgunEnemList[i].activeInHierarchy == false)
                {
                    ObjectPooling.Instance.ShotgunEnemList[i].SetActive(true);
                    ObjectPooling.Instance.ShotgunEnemList[i].transform.position = Spawners[4].transform.position;
                    ObjectPooling.Instance.ShotgunEnemList[i].transform.rotation = Spawners[4].transform.rotation;
                    break;
                }
            }
        }
    }

    public void SpawnEnemiesOverTime()
    {

    }
}
