using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour {
    public Camera cam;
    public Text txt;
    public NavMeshAgent ag;
    private Vector3 R390=new Vector3(949,1030,0);
    private Vector3 R380 = new Vector3(763, 855, 0);
    private Vector3 R370 = new Vector3(348, 1030, 0);
    private Vector3 R360 = new Vector3(185, 1006, 0);
    public void Room390()
    {
        Debug.Log(Input.mousePosition);
        Ray ray = cam.ScreenPointToRay(R390);
        txt.text = Convert.ToString(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            ag.SetDestination(hit.point);

        }

    }
    public void Room380(){
        Debug.Log(Input.mousePosition);
        Ray ray = cam.ScreenPointToRay(R380);
        txt.text = Convert.ToString(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            ag.SetDestination(hit.point);

        }
       
    }
    public void Room370()
    {
        Debug.Log(Input.mousePosition);
        Ray ray = cam.ScreenPointToRay(R370);
        txt.text = Convert.ToString(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            ag.SetDestination(hit.point);

        }

    }
    public void Room360()
    {
        Debug.Log(Input.mousePosition);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        txt.text = Convert.ToString(R360);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            ag.SetDestination(hit.point);

        }

    }
    void Update()
    { 
       //if (Input.GetMouseButtonDown(0))
       // {
       //     Ray ray = cam.ScreenPointToRay(Input.mousePosition);
       //     Debug.Log(Input.mousePosition);
       //     RaycastHit hit;
       //     if (Physics.Raycast(ray, out hit))
       //     {

       //         ag.SetDestination(hit.point);

       //     }

       // }
    }
    }
