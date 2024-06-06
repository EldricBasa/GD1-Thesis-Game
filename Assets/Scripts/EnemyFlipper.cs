using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlipper : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    private Transform currentPoint;

    void Start(){
        currentPoint = pointB.transform;
    }
    void Update()
    {
        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform) {
            flip();
            currentPoint = pointA.transform;
        }
        if(Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform) {
            flip();
            currentPoint = pointB.transform;
        }
    }
    private void flip() {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
