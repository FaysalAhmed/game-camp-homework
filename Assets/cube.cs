using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour {
	public float speed = 10.0F;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	void Update () {
		/*
		Vector3 dir = Vector3.zero;
		dir.x = -Input.acceleration.y;
		dir.z = Input.acceleration.x;
		if (dir.sqrMagnitude > 1)
			dir.Normalize();
		
		dir *= Time.deltaTime;
		print (Input.acceleration);
*/
		//transform.Translate(dir * speed);
		transform.Translate(Input.acceleration.x*0.1f, -Input.acceleration.z*0.1f,0 );
	}


}
