using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    public float followSpeed, yPos;

    private Transform tank_green;
    
    void Start()
    {
        tank_green = GameObject.Find("tank_green").transform;
    }

    
    void FixedUpdate()
    {
        Vector2 targetPos = tank_green.position;
        Vector2 smoothPos = Vector2.Lerp(transform.position, targetPos, followSpeed * Time.deltaTime);

        transform.position = new Vector3(smoothPos.x, smoothPos.y + yPos, -15f);
    }
}
