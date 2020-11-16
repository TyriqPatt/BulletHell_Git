using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{

    public Transform Target;
    public float speed;
    public bool pingpong;
    public bool pingpongL;
    public bool pingpongR;
    public bool RandSpeed;

    // Start is called before the first frame update
    void OnEnable()
    {
        if (RandSpeed)
        {
            speed = Random.Range(1, 4);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (pingpong)
        {
            if (pingpongL)
            {
                transform.localRotation = Quaternion.Euler(00, -Mathf.PingPong(Time.time * speed, 90), 00);
            }
            if (pingpongR)
            {
                transform.localRotation = Quaternion.Euler(00, Mathf.PingPong(Time.time * speed, 90), 00);
            }
            
        }
        else
        {
            if (!RandSpeed)
            {
                transform.RotateAround(Target.position, Vector3.down, speed);
            }
            else
            {
                transform.RotateAround(Target.position, Vector3.down, speed);
            }
        }
    }
}
