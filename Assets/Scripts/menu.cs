using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class menu : MonoBehaviour {

	private int anim1 = Animator.StringToHash("mainState");
	private int anim2 = Animator.StringToHash("hudState");

	private Animator animator1;
	private Animator animator2;

	// Use this for initialization
	void Start () {

		animator1 = this.transform.Find ("Main").GetComponent<Animator> ();
		animator2 = this.transform.Find ("Hud").GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setLevelText(string name){
		this.transform.Find ("Hud").transform.Find ("headline").GetComponent<Text> ().text = "LVL " + name;
	}


	public void animateMenu(){
		animator1.SetInteger (anim1, 1);
		animator2.SetInteger (anim2, 1);
	}


}
