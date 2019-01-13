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
    /*------------------------*/
    private Vector3 R141 = new Vector3(185, 1006, 0);
    private Vector3 R142=new Vector3(743,1046,0);
    private Vector3 R143 = new Vector3(666, 1087, 0);
    private Vector3 R144 = new Vector3(554, 1135, 0);
    private Vector3 R145 = new Vector3(185, 1006, 0);
    /*------------------------*/
    private Vector3 R119 = new Vector3(949, 1030, 0);
    private Vector3 R122 = new Vector3(763, 855, 0);
    private Vector3 R124 = new Vector3(348, 1030, 0);
    private Vector3 R125 = new Vector3(185, 1006, 0);
    private Vector3 R127 = new Vector3(348, 1030, 0);
    private Vector3 R129 = new Vector3(185, 1006, 0);
    /*------------------------*/
    private Vector3 R110 = new Vector3(348, 1030, 0);
    private Vector3 R109 = new Vector3(185, 1006, 0);
    /*------------------------*/
    public void Room141()
    {
        Debug.Log(Input.mousePosition);
        Ray ray = cam.ScreenPointToRay(R141);
        txt.text = Convert.ToString(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            ag.SetDestination(hit.point);

        }

    }
    public void Room142()
    {
        Debug.Log(Input.mousePosition);
        Ray ray = cam.ScreenPointToRay(R142);
        txt.text = Convert.ToString(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            ag.SetDestination(hit.point);

        }

    }
    public void Room143(){
        Debug.Log(Input.mousePosition);
        Ray ray = cam.ScreenPointToRay(R143);
        txt.text = Convert.ToString(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            ag.SetDestination(hit.point);

        }
       
    }
    public void Room144()
    {
        Debug.Log(Input.mousePosition);
        Ray ray = cam.ScreenPointToRay(R144);
        txt.text = Convert.ToString(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            ag.SetDestination(hit.point);

        }

    }
    public void Room145()
    {
        Debug.Log(Input.mousePosition);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        txt.text = Convert.ToString(R145);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            ag.SetDestination(hit.point);

        }

    }
    /*------------------------*/
    public void Room119()
    {
        Debug.Log(Input.mousePosition);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        txt.text = Convert.ToString(R119);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            ag.SetDestination(hit.point);

        }

    }
    public void Room122()
    {
        Debug.Log(Input.mousePosition);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        txt.text = Convert.ToString(R122);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            ag.SetDestination(hit.point);

        }

    }
    public void Room124()
    {
        Debug.Log(Input.mousePosition);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        txt.text = Convert.ToString(R124);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            ag.SetDestination(hit.point);

        }

    }
    public void Room125()
    {
        Debug.Log(Input.mousePosition);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        txt.text = Convert.ToString(R125);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            ag.SetDestination(hit.point);

        }

    }
    public void Room127()
    {
        Debug.Log(Input.mousePosition);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        txt.text = Convert.ToString(R127);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            ag.SetDestination(hit.point);

        }

    }
    public void Room129()
    {
        Debug.Log(Input.mousePosition);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        txt.text = Convert.ToString(R129);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            ag.SetDestination(hit.point);

        }

    }
    /*------------------------*/
    public void Room109()
    {
        Debug.Log(Input.mousePosition);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        txt.text = Convert.ToString(R109);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            ag.SetDestination(hit.point);

        }

    }
    public void Room110()
    {
        Debug.Log(Input.mousePosition);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        txt.text = Convert.ToString(R110);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            ag.SetDestination(hit.point);

        }

    }
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        //    Debug.Log(Input.mousePosition);
        //    RaycastHit hit;
        //    if (Physics.Raycast(ray, out hit))
        //    {

        //        ag.SetDestination(hit.point);

        //    }

        //}
    }
    }
