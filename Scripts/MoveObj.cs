using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour {

    public float speed;
    public Vector3 MoveVec;
	void Start () {
        Destroy(gameObject, 10);
	}
	
	
	void Update () {
        gameObject.transform.Translate(MoveVec * Time.deltaTime * speed);
	}
}
