using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Enemies : MonoBehaviour
{

    public GameObject[] Enemies;
    public GameObject[] Spawners;
    public int rand;
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
    }

    void Spawner1()
    {
        rand = Random.Range(0, 4);
        if (rand == 0)
        {
            Instantiate(Enemies[0], Spawners[0].transform.position, transform.rotation);
        }
        else if (rand == 1)
        {
            Instantiate(Enemies[1], Spawners[0].transform.position, transform.rotation);
        }
        else if (rand == 2)
        {
            Instantiate(Enemies[2], Spawners[0].transform.position, transform.rotation);
        }
        else if (rand == 3)
        {
            Instantiate(Enemies[3], Spawners[0].transform.position, transform.rotation);
        }
    }

    void Spawner2()
    {
        rand = Random.Range(0, 4);
        if (rand == 0)
        {
            Instantiate(Enemies[0], Spawners[1].transform.position, transform.rotation);
        }
        else if (rand == 1)
        {
            Instantiate(Enemies[1], Spawners[1].transform.position, transform.rotation);
        }
        else if (rand == 2)
        {
            Instantiate(Enemies[2], Spawners[1].transform.position, transform.rotation);
        }
        else if (rand == 3)
        {
            Instantiate(Enemies[3], Spawners[1].transform.position, transform.rotation);
        }
    }

    void Spawner3()
    {
        rand = Random.Range(0, 4);
        if (rand == 0)
        {
            Instantiate(Enemies[0], Spawners[2].transform.position, transform.rotation);
        }
        else if (rand == 1)
        {
            Instantiate(Enemies[1], Spawners[2].transform.position, transform.rotation);
        }
        else if (rand == 2)
        {
            Instantiate(Enemies[2], Spawners[2].transform.position, transform.rotation);
        }
        else if (rand == 3)
        {
            Instantiate(Enemies[3], Spawners[2].transform.position, transform.rotation);
        }
    }

    void Spawner4()
    {
        rand = Random.Range(0, 4);
        if (rand == 0)
        {
            Instantiate(Enemies[0], Spawners[3].transform.position, transform.rotation);
        }
        else if (rand == 1)
        {
            Instantiate(Enemies[1], Spawners[3].transform.position, transform.rotation);
        }
        else if (rand == 2)
        {
            Instantiate(Enemies[2], Spawners[3].transform.position, transform.rotation);
        }
        else if (rand == 3)
        {
            Instantiate(Enemies[3], Spawners[3].transform.position, transform.rotation);
        }
    }

    void Spawner5()
    {
        rand = Random.Range(0, 4);
        if (rand == 0)
        {
            Instantiate(Enemies[0], Spawners[4].transform.position, transform.rotation);
        }
        else if (rand == 1)
        {
            Instantiate(Enemies[1], Spawners[4].transform.position, transform.rotation);
        }
        else if (rand == 2)
        {
            Instantiate(Enemies[2], Spawners[4].transform.position, transform.rotation);
        }
        else if (rand == 3)
        {
            Instantiate(Enemies[3], Spawners[4].transform.position, transform.rotation);
        }
    }
}
