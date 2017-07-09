using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContol : MonoBehaviour
{
    public Transform Target;

    public Vector3 Left;
    public Vector3 Right;
    private Vector3 offset;
    public float speed;
    public bool IsLeft;
    public bool IsRight;

    private void Start()
    {
        offset = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
    }

    private void Update()
    {
        Vector3 MoveVector = new Vector3(Target.position.x, Target.position.y, 7.2f);
        if(IsLeft == true)
        {
            if(Target.position.x < 1.9f)
            {
                Target.transform.Translate(Left * Time.deltaTime * speed);
            }

        }
        if (IsRight == true)
        {
            if (Target.position.x > -1.9f)
            {
                Target.transform.Translate(Right * Time.deltaTime * speed);
            }

        }
        transform.LookAt(Target);
        transform.position = Vector3.MoveTowards(transform.position, MoveVector, Time.deltaTime * (speed - 1f));
    }

    public void turnRight(bool Ison)
    {
        IsRight = Ison;
    }
    public void turnLeft(bool Ison)
    {
       IsLeft = Ison;
    }



}
