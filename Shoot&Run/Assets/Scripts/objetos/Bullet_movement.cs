﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_movement : MonoBehaviour
{

	float segundos = 1.00f;
    // Use this for initialization
    void Start()
    {
		Destroy (gameObject, segundos);
    }

    // Update is called once per frame
    void Update()
    {


			/*transform.position = new Vector3(transform.localPosition.x,
            transform.localPosition.y + speed * Time.deltaTime,
            transform.localPosition.z);
		print ("bala frame");*/
			gameObject.GetComponent<Rigidbody2D> ().AddRelativeForce (new Vector2 (transform.localPosition.x,
				transform.localPosition.y + 100));
    }

}

