using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyType : MonoBehaviour
{

    public Transform eye;
    public GameObject Bullet;
    public int BulletsSpawned = 7;
    public float AltAmmo;
    public Rigidbody Rig;
    public List<GameObject> BulletList = new List<GameObject>();
    public GameObject DashSawPart;
    public enum State {Shotgun, FourShot, BuzzSaw, DashSaw, Sniper}

    public State EnemyTypes;

    // Start is called before the first frame update
    void Start()
    {
        DashSawPart.SetActive(false);
        Rig = GetComponent<Rigidbody>();
        for (int i = 0; i < BulletsSpawned; i++)
        {
            GameObject objects = Instantiate(Bullet, this.transform.position, Quaternion.identity) as GameObject;
            objects.transform.parent = this.transform;
            objects.SetActive(false);
            BulletList.Add(objects);
        }
        StartCoroutine(DashSaw(3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Burst(float timer)
    {
        int i = 0;
        i += 1;
        yield return new WaitForSeconds(timer);
        BulletList[i].GetComponent<ShotBehavior>().ClassState = ShotBehavior.State.Commander;
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
    }

    IEnumerator Shotgun()
    {
        yield return new WaitForSeconds(1);
        BulletList[0].GetComponent<ShotBehavior>().ClassState = ShotBehavior.State.Commander;
        BulletList[0].SetActive(true);
        BulletList[0].transform.position = eye.transform.position;
        BulletList[0].transform.rotation = eye.transform.rotation;
        BulletList[1].GetComponent<ShotBehavior>().ClassState = ShotBehavior.State.Commander;
        BulletList[1].SetActive(true);
        BulletList[1].transform.position = new Vector3(eye.transform.position.x +.5f, eye.transform.position.y, eye.transform.position.z);
        BulletList[1].transform.rotation = new Quaternion(eye.transform.rotation.x - 45, eye.transform.rotation.y, eye.transform.rotation.y, eye.transform.rotation.w);
        BulletList[2].GetComponent<ShotBehavior>().ClassState = ShotBehavior.State.Commander;
        BulletList[2].SetActive(true);
        BulletList[2].transform.position = new Vector3(eye.transform.position.x - .5f, eye.transform.position.y, eye.transform.position.z);
        BulletList[2].transform.rotation = new Quaternion(eye.transform.rotation.x + 45, eye.transform.rotation.y, eye.transform.rotation.y, eye.transform.rotation.w);
    }

    IEnumerator DashSaw(float timer)
    {
        yield return new WaitForSeconds(timer);
        Rig.velocity = transform.forward * 40;
        DashSawPart.SetActive(true);
        yield return new WaitForSeconds(.15f);
        Rig.velocity = Vector3.zero;
        yield return new WaitForSeconds(.08f);

        Rig.velocity = transform.forward * 40;
        yield return new WaitForSeconds(.15f);
        Rig.velocity = Vector3.zero;
        yield return new WaitForSeconds(.08f);

        Rig.velocity = transform.forward * 40;
        yield return new WaitForSeconds(.15f);
        Rig.velocity = Vector3.zero;
        yield return new WaitForSeconds(.08f);
        DashSawPart.SetActive(false);
    }
}
