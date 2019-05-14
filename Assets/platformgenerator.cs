using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class platformgenerator : MonoBehaviour
{
    public GameObject floor;
    public Transform generationPoint;
    private float distanceBetween;
    private List<float> list = new List<float>() { 0,1,2,3};
    private System.Random r= new System.Random();

    public GameObject hindernis1;
    public GameObject hindernis2;
    private List<float> listX = new List<float>() { -3,-2,-1,0, 1, 2, 3 };
    private List<float> listY = new List<float>() { 1, 2, 3 };
    private List<GameObject> listGameObjects = new List<GameObject>();



    private float floorWith;

    // Start is called before the first frame update
    void Start()
    {
          
        floorWith = floor.GetComponent<Transform>().localScale.x;
        listGameObjects.Add(hindernis1);
        listGameObjects.Add(hindernis2);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {
            int index = r.Next(list.Count);
            distanceBetween = list[index];
            transform.position = new Vector3(transform.position.x + floorWith + distanceBetween,transform.position.y);

            Instantiate(floor, transform.position, transform.rotation);

            int indexX = r.Next(listX.Count);
            int indexY = r.Next(listY.Count);
            int indexGameObjects = r.Next(listGameObjects.Count);
            Instantiate(listGameObjects[indexGameObjects], new Vector3(transform.position.x + listX[indexX], transform.position.y + listY[indexY],transform.position.z), transform.rotation);
        }

    }
}
