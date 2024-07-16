using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    public Transform goal;
    float speed = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookAtGoal = new Vector3(goal.position.x, this.transform.position.y, goal.position.z);
        transform.LookAt(lookAtGoal);

        if (Vector3.Distance(lookAtGoal, transform.position) > 1)
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

    }


}
