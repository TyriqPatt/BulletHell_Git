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
    Vector3 smoothpos;
    public EnemyType E_Type;


    public enum State { move, attack }

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
        Self.transform.LookAt(player);
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
            if(distance > AttackRange)
            {
                EnemyState = State.move;

            }
        }
    }
}
