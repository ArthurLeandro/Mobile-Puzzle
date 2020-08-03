using UnityEngine;
using System.Collections;

public class lightSwitch : MonoBehaviour {


	public bool isOn = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void change(){

		Vector3 curPos = this.transform.Find ("Plane").position;

		if(isOn){

			isOn = false;
			this.transform.Find("Plane").position = new Vector3(curPos.x,curPos.y,curPos.z +.5f);
			//this.transform.localEulerAngles = new Vector3(0,45,0);
		
		}else{
			isOn = true;
			this.transform.Find("Plane").position = new Vector3(curPos.x,curPos.y,curPos.z -.5f);
			//this.transform.localEulerAngles = Vector3.zero;
		}
	}



}
