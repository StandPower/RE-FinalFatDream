using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogEngine : MonoBehaviour {

	public Text DialogText;

	// Use this for initialization
	void Start () {
		DialogText.text = "Fuck myself";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick(){
		DialogText.text = "Fuck yourself";
	}
}
