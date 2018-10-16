using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyAndDie : MonoBehaviour {
	public Rigidbody rb;
	public int moveSpeed;

	// Use this for initialization
	void Start () 
	{
		rb.AddRelativeForce (Vector3.forward * moveSpeed, ForceMode.Impulse);
		Destroy (gameObject, 4f);	//destroys the object 4 seconds after launch
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collider other){
		print (destroyWhenCharged.enemiesDestroyed);
		destroyWhenCharged.enemiesDestroyed++;
		Destroy (gameObject);
	}
		
}
	
