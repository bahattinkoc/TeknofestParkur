using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tahta : MonoBehaviour {

	int pos_and_rot_counter = 0;
	Vector3[] position_array = {new Vector3(-60f, 2.5f, 84.6f), new Vector3(-77f, 2.5f, 80f)};
	Vector3[] rotation_array = {new Vector3(-90f, 180f, 0f), new Vector3(-90f, 180f, -41f)};

		// Use this for initialization
	void Start () {
		Quaternion qua = new Quaternion();
		qua.eulerAngles = rotation_array[pos_and_rot_counter];
		transform.rotation = qua;

		transform.position = position_array[pos_and_rot_counter];
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown(KeyCode.Q)){
			if(pos_and_rot_counter < position_array.Length)
				pos_and_rot_counter++;
			
			transform.position = position_array[pos_and_rot_counter];
			
			Quaternion qua = new Quaternion();
			qua.eulerAngles = rotation_array[pos_and_rot_counter];
			transform.rotation = qua;
		}
		if(Input.GetKeyDown(KeyCode.E)){
			if(pos_and_rot_counter != 0)
				pos_and_rot_counter--;
			
			transform.position = position_array[pos_and_rot_counter];
			
			Quaternion qua = new Quaternion();
			qua.eulerAngles = rotation_array[pos_and_rot_counter];
			transform.rotation = qua;
		}
	}
}
