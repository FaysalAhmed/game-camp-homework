﻿using UnityEngine;
using System.Collections;

public class gameMaster : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void changeScene(){
		Application.LoadLevel("level1");
	}


}
