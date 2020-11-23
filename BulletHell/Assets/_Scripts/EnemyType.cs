using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType : MonoBehaviour
{

    public Transform eye, eye1, eye2;
    public GameObject Bullet;
    EnemyMovement Movement;
    public int BulletsSpawned = 7;
    public float AltAmmo;
    public int i = 0;
    public Rigidbody Rig;
    public List<GameObject> BulletList = new List<GameObject>();
    public GameObject DashSawPart;
    public enum State {Shotgun, BurstShot, BuzzSaw, DashSaw, Sniper}

    public State EnemyTypes;

    // Start is called before the first frame update
    void Start()
    {
        Rig = GetComponent<Rigidbody>();
        Movement = GetComponentInParent<EnemyMovement>();
        Movement.CanRot = true;
        if (EnemyTypes == State.DashSaw)
        {
            DashSawPart.SetActive(false);
        }
        
        if (EnemyTypes == State.Shotgun || EnemyTypes == State.BurstShot)
        {
            for (int i = 0; i < BulletsSpawned; i++)
            {
                GameObject objects = Instantiate(Bullet, this.transform.position, Quaternion.identity) as GameObject;
                objects.transform.parent = transform.parent;
                objects.SetActive(false);
                BulletList.Add(objects);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CallBurst()
    {
        StartCoroutine(Burst(1));
        i = 0;
        AltAmmo = 4;
    }

    IEnumerator Burst(float timer)
    {
        
        i += 1;
        yield return new WaitForSeconds(timer);
        BulletList[i].GetComponent<ShotBehavior>().ClassState = ShotBehavior.State.Enemy;
        BulletList[i].SetActive(true);
        BulletList[i].transform.position = eye.transform.position;
        BulletList[i].transform.rotation = eye.transform.rotation;
        if (AltAmmo > 0)
        {
            if (AltAmmo > 1)
            {
                StartCoroutine(Burst(.2f));
            }
            AltAmmo -= 1;
        }
        StartCoroutine(BurstWait());
    }
    IEnumerator BurstWait()
    {
        if (AltAmmo == 0)
        {
            yield return new WaitForSeconds(2);
            CheckPlayerDis();
        }
    }

    public void CallShotgun()
    {
        StartCoroutine(Shotgun());
    }

    IEnumerator Shotgun()
    {
        yield return new WaitForSeconds(1);
        BulletList[0].GetComponent<ShotBehavior>().ClassState = ShotBehavior.State.Enemy;
        BulletList[0].SetActive(true);
        BulletList[0].transform.position = eye.transform.position;
        BulletList[0].transform.rotation = eye.transform.rotation;
        BulletList[1].GetComponent<ShotBehavior>().ClassState = ShotBehavior.State.Enemy;
        BulletList[1].SetActive(true);
        BulletList[1].transform.position = eye1.transform.position;
        BulletList[1].transform.rotation = eye1.transform.rotation;
        BulletList[2].GetComponent<ShotBehavior>().ClassState = ShotBehavior.State.Enemy;
        BulletList[2].SetActive(true);
        BulletList[2].transform.position = eye2.transform.position;
        BulletList[2].transform.rotation = eye2.transform.rotation;
        yield return new WaitForSeconds(2);
        CheckPlayerDis();
    }

    public void CallDash()
    {
        StartCoroutine(DashSaw(.5f));
    }

    IEnumerator DashSaw(float timer)
    {
        yield return new WaitForSeconds(timer);
        Movement.CanRot = false;
        Rig.velocity = transform.forward * 40;
        DashSawPart.SetActive(true);
        yield return new WaitForSeconds(.5f);
        Rig.velocity = Vector3.zero;
        yield return new WaitForSeconds(.08f);
        DashSawPart.SetActive(false);
        yield return new WaitForSeconds(1);
        Movement.CanRot = true;
        CheckPlayerDis();
    }


    void CheckPlayerDis()
    {
        if (Movement.distance > Movement.AttackRange)
        {
            Movement.EnemyState = EnemyMovement.State.move;
        }
        else
        {
            Movement.EnemyState = EnemyMovement.State.attack;
        }
    }
}
