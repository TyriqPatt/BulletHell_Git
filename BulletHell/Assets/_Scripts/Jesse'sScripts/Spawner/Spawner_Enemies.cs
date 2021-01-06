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
        Spawner1();
        Spawner2();
        Spawner3();
        Spawner4();
        Spawner5();
        this.enabled = false;
    }

    void Spawner1()
    {
        int rand;
        rand = Random.Range(0, 4);
        if (rand == 0)
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
        else if (rand == 1)
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
        else if (rand == 2)
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
        else if (rand == 3)
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
    }

    void Spawner2()
    {
        int rand;
        rand = Random.Range(0, 4);
        if (rand == 0)
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
        else if (rand == 1)
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
        else if (rand == 2)
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
        else if (rand == 3)
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
    }

    void Spawner3()
    {
        int rand;
        rand = Random.Range(0, 4);
        if (rand == 0)
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
        else if (rand == 1)
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
        else if (rand == 2)
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
        else if (rand == 3)
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
    }

    void Spawner4()
    {
        int rand;
        rand = Random.Range(0, 4);
        if (rand == 0)
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
        else if (rand == 1)
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
        else if (rand == 2)
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
        else if (rand == 3)
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
    }

    void Spawner5()
    {
        int rand;
        rand = Random.Range(0, 4);
        if (rand == 0)
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
        else if (rand == 1)
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
        else if (rand == 2)
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
        else if (rand == 3)
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
}
