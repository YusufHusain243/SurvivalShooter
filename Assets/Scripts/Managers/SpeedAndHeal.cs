using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedAndHeal : MonoBehaviour
{
    Vector3 pos;
    Transform target;

    private void Update()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        float step = 5.0f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        if(gameObject.transform.position == target.position)
        {
            Destroy(gameObject);
        }
    }
}