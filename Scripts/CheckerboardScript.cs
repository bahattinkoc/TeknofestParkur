using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerboardScript : MonoBehaviour {

	int index = 0;//25
	Vector3[] position_array = {new Vector3(-60f, 2.5f, 84.6f), new Vector3(-77f, 2.5f, 80f)
								, new Vector3(-82f, 2.5f, 72f), new Vector3(-82f, 2.5f, 60.5f)
								, new Vector3(-82f, 2.5f, 45f), new Vector3(-82f, 2.5f, 30f)
								, new Vector3(-82f, 2.5f, 15f), new Vector3(-82f, 2.5f, 0f)
								, new Vector3(-82f, 2.5f, -15f), new Vector3(-82f, 2.5f, -30f)
								, new Vector3(-82f, 2.5f, -50f), new Vector3(-82f, 2.5f, -65f)
								, new Vector3(-82f, 2.5f, -80f), new Vector3(-82f, 2.5f, -95f)
								, new Vector3(-78.5f, 2.5f, -110f), new Vector3(-66f, 2.5f, -118.5f)
								, new Vector3(-50f, 2.5f, -118.5f), new Vector3(-35f, 2.5f, -118.5f)
								, new Vector3(-10f, 2.5f, -118.5f), new Vector3(10f, 2.5f, -118.5f)
								, new Vector3(25f, 2.5f, -118.5f), new Vector3(40f, 2.5f, -118.5f)
								, new Vector3(55f, 2.5f, -118.5f), new Vector3(70f, 2.5f, -118.5f)
								, new Vector3(85f, 2.5f, -118.5f), new Vector3(107f, 2.5f, -109f)
								, new Vector3(112.2f, 2.5f, -96f), new Vector3(112.2f, 2.5f, -80f)
								, new Vector3(112.2f, 2.5f, -65f), new Vector3(112.2f, 2.5f, -50f)
								, new Vector3(112.2f, 2.5f, -25f), new Vector3(112.2f, 2.5f, -10f)
								, new Vector3(112.2f, 2.5f, 5f), new Vector3(112.2f, 2.5f, 20f)
								, new Vector3(105f, 2.5f, 36f), new Vector3(88f, 2.5f, 44.5f)
								, new Vector3(60f, 2.5f, 44.5f), new Vector3(40f, 2.5f, 44.5f)
								, new Vector3(15f, 2.5f, 44.5f), new Vector3(0f, 2.5f, 44.5f)
								, new Vector3(0f, 2.5f, 60f), new Vector3(0f, 2.5f, 70f)
								, new Vector3(-3.4f, 2.5f, 79f), new Vector3(-14f, 2.5f, 85f)
								, new Vector3(-30f, 2.5f, 85f)};

	Vector3[] rotation_array = {new Vector3(-90f, 180f, 0f), new Vector3(-90f, 180f, -41f)
								,new Vector3(-90f, 152f, -41f), new Vector3(-90f, 130f, -41f)
								,new Vector3(-90f, 130f, -41f), new Vector3(-90f, 130f, -41f)
								, new Vector3(-90f, 130f, -41f), new Vector3(-90f, 130f, -41f)
								, new Vector3(-90f, 130f, -41f), new Vector3(-90f, 130f, -41f)
								, new Vector3(-90f, 130f, -41f), new Vector3(-90f, 130f, -41f)
								, new Vector3(-90f, 130f, -41f), new Vector3(-90f, 130f, -41f)
								, new Vector3(-90f, 100f, -41f), new Vector3(-90f, 40f, -41f)
								, new Vector3(-90f, 40f, -41f), new Vector3(-90f, 40f, -41f)
								, new Vector3(-90f, 40f, -41f), new Vector3(-90f, 40f, -41f)
								, new Vector3(-90f, 40f, -41f), new Vector3(-90f, 40f, -41f)
								, new Vector3(-90f, 40f, -41f), new Vector3(-90f, 40f, -41f)
								, new Vector3(-90f, 40f, -41f), new Vector3(-90f, 0f, -41f)
								, new Vector3(-90f, -45f, -41f), new Vector3(-90f, -45f, -41f)
								, new Vector3(-90f, -45f, -41f), new Vector3(-90f, -45f, -41f)
								, new Vector3(-90f, -45f, -41f), new Vector3(-90f, -45f, -41f)
								, new Vector3(-90f, -45f, -41f), new Vector3(-90f, -45f, -41f)
								, new Vector3(-90f, -85f, -41f), new Vector3(-90f, -140f, -41f)
								, new Vector3(-90f, -140f, -41f), new Vector3(-90f, -140f, -41f)
								, new Vector3(-90f, -140f, -41f), new Vector3(-90f, -140f, -41f)
								, new Vector3(-90f, -45f, -41f), new Vector3(-90f, -45f, -41f)
								, new Vector3(-90f, -80f, -41f), new Vector3(-90f, -140f, -41f)
								, new Vector3(-90f, -140f, -41f)};

	void Start () {
		Quaternion qua = new Quaternion();
		qua.eulerAngles = rotation_array[index];
		transform.rotation = qua;

		transform.position = position_array[index];
	}
	
	void Update () {
		//Bir sonraki konuma gidiyor
		if(Input.GetKeyDown(KeyCode.Q)){
			if(index < position_array.Length){
				index++;
				UpdateCheckerBoard();	
			}
		}
		//Bir önceki konuma geliyor
		if(Input.GetKeyDown(KeyCode.E)){
			if(index != 0){
				index--;
				UpdateCheckerBoard();
			}
		}
	}

	void UpdateCheckerBoard(){
		transform.position = position_array[index];
		
		Quaternion qua = new Quaternion();
		qua.eulerAngles = rotation_array[index];
		transform.rotation = qua;
	}
}
