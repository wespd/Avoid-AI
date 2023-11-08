using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followpath : MonoBehaviour
{
    public float speed;
    public Transform[] points;
    public int currentPoint = 0;
    public bool inReverse;
    bool atPoint => transform.position == points[currentPoint].position;

    // Update is called once per frame
    void Update()
    {   
        if(atPoint && currentPoint < points.Length - 1 &&  !inReverse)
        {
            currentPoint ++;
            if(currentPoint == points.Length -1)
            {
                inReverse = true;
            }
        }
        else if(atPoint && inReverse)
        {
            currentPoint --;
            if(currentPoint == 0)
            {
                inReverse = false;
            }
        }
        transform.right = points[currentPoint].position - transform.position;
        transform.position = Vector3.MoveTowards(transform.position, points[currentPoint].position, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
    
        
        for(int i = 1; i < points.Length; i++)
        {
            if(points[i-1] != null && points[i] != null)
            {
                Gizmos.DrawLine(points[i - 1].position, points[i].position);
            }
        }
        
    }
}