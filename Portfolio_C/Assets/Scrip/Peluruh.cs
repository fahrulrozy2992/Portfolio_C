using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peluruh : MonoBehaviour {

    float speed = 40f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        Destroy(gameObject, 15f);
	}
}
