﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddRooms : MonoBehaviour
{

    RoomTemplates templates;
    public Transform RayPoint;
    bool FDeadend;
    bool RDeadend;
    bool LDeadend;
    bool BDeadend;
    public GameObject FD;
    public GameObject RD;
    public GameObject LD;
    public GameObject BD;
    public GameObject MMObject;
    public Image MMBackGround;
    public int NumInlist;
    //BoxCollider BC;
    //public Vector3 BCSize;


    private void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        templates.rooms.Add(this.gameObject);
        wallup();
        //BC = GetComponent<BoxCollider>();
        //BCSize.x = 85;
        //BCSize.y = 5;
        //BCSize.z = 45;
        //BC.size = BCSize;
    }

    public void wallup()
    {
        WallDectection();
        if (FDeadend)
        {
            FD.SetActive(true);
        }
        if (RDeadend)
        {
            RD.SetActive(true);
        }
        if (BDeadend)
        {
            BD.SetActive(true);
        }
        if (LDeadend)
        {
            LD.SetActive(true);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            CloseDoor();
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            
        }
    }

    public void CloseDoor()
    {
        if(FD != null && !FD.activeSelf)
        {
            FD.SetActive(true);
            FD.GetComponent<Renderer>().material.color = Color.red;
        }
        if (RD != null && !RD.activeSelf)
        {
            RD.SetActive(true);
            RD.GetComponent<Renderer>().material.color = Color.red;
        }
        if (BD != null && !BD.activeSelf)
        {
            BD.SetActive(true);
            BD.GetComponent<Renderer>().material.color = Color.red;
        }
        if (LD != null && !LD.activeSelf)
        {
            LD.SetActive(true);
            LD.GetComponent<Renderer>().material.color = Color.red;
        }
    }

    public void OpenDoors()
    {
        if (FD != null && !FD.activeSelf)
        {
            FD.SetActive(false);
        }
        if (RD != null && !RD.activeSelf)
        {
            RD.SetActive(false);
        }
        if (BD != null && !BD.activeSelf)
        {
            BD.SetActive(false);
        }
        if (LD != null && !LD.activeSelf)
        {
            LD.SetActive(false);
        }
    }


    public void WallDectection()
    {
        RaycastHit hit;
        //Does the ray intersect a wall of the room on top of it
        if (Physics.Raycast(RayPoint.position, RayPoint.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(RayPoint.position, RayPoint.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        }
        if (hit.distance > 37.125 && hit.distance < 40 && hit.transform.name == "Wall")
        {
            FDeadend = true;
        }

        RaycastHit hit2;
        //Does the ray intersect a wall of the room below it
        if (Physics.Raycast(RayPoint.position, RayPoint.TransformDirection(Vector3.back), out hit2, Mathf.Infinity))
        {
            Debug.DrawRay(RayPoint.position, RayPoint.TransformDirection(Vector3.back) * hit2.distance, Color.yellow);
        }
        if (hit2.distance > 37.125 && hit2.distance < 40 && hit2.transform.name == "Wall")
        {
            BDeadend = true;
        }

        RaycastHit hit3;
        //Does the ray intersect a wall of the room on the right of it
        if (Physics.Raycast(RayPoint.position, RayPoint.TransformDirection(Vector3.right), out hit3, Mathf.Infinity))
        {
            Debug.DrawRay(RayPoint.position, RayPoint.TransformDirection(Vector3.right) * hit3.distance, Color.yellow);
        }
        if (hit3.distance > 67.125 && hit3.distance < 70 && hit3.transform.name == "Wall")
        {
            RDeadend = true;
        }

        RaycastHit hit4;
        //Does the ray intersect a wall of the room on the left of it
        if (Physics.Raycast(RayPoint.position, RayPoint.TransformDirection(Vector3.left), out hit4, Mathf.Infinity))
        {
            Debug.DrawRay(RayPoint.position, RayPoint.TransformDirection(Vector3.left) * hit4.distance, Color.yellow);
        }
        if (hit4.distance > 67.125 && hit4.distance < 70 && hit4.transform.name == "Wall")
        {
            LDeadend = true;
        }
    }

    public void CheckFirstRoomForMM()
    {
        if(NumInlist == 0)
        {
            MMObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MMObject.SetActive(true);
            MMBackGround.color = Color.red;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MMBackGround.color = Color.white;
        }
    }
}
