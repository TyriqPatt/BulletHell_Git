using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Transform player;
    public Transform Self;
    public float AttackRange;
    public float distance;
    public float speed;
    public bool CanRot;
    Vector3 smoothpos;
    public EnemyType E_Type;

    public enum State { move, attack, idle}

    public State EnemyState;

    // Start is called before the first frame update
    void Start()
    {
        smoothpos = transform.position;
        Self = transform.GetChild(0);
        E_Type = Self.GetComponent<EnemyType>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (CanRot)
        {
            //Self.transform.LookAt(player);
            Vector3 targetDirection = player.transform.position - Self.transform.position;
            Vector3 newDirection = Vector3.RotateTowards(Self.transform.forward, targetDirection, 2 * Time.deltaTime, 0.0f);
            Self.transform.rotation = Quaternion.LookRotation(newDirection);
        }
        
        distance = Vector3.Distance(Self.transform.position, player.position);
        if (EnemyState == State.move)
        {
            if (distance > AttackRange)
            {
                Self.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
            else
            {
                EnemyState = State.attack;
            } 
        }
        else if(EnemyState == State.attack)
        {
            if(E_Type.EnemyTypes == EnemyType.State.BurstShot)
            {
                E_Type.CallBurst();
                EnemyState = State.idle;
            }

            if (E_Type.EnemyTypes == EnemyType.State.DashSaw)
            {
                E_Type.CallDash();
                EnemyState = State.idle;

            }

            if (E_Type.EnemyTypes == EnemyType.State.Shotgun)
            {
                E_Type.CallShotgun();
                EnemyState = State.idle;
            }
        }
        else if(EnemyState == State.idle)
        {

        }
    }
}
