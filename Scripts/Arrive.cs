﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Arrive : SteeringBehaviour
{
    public Vector3 targetPosition = Vector3.zero;
    public float slowingDistance = 15.0f;

    public GameObject targetGameObject;

    public void Update()
    {
        if (targetGameObject != null)
        {
            targetPosition = targetGameObject.transform.position;
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + force * 100);
        //Gizmos.DrawSphere(transform.position, 10);
    }

    public override Vector3 Calculate()
    {
        Vector3 force = boid.ArriveForce(targetPosition, slowingDistance);
        return force;
    }

}