using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{	
	public Text dialog;
	public Button nextButton;
	AVGEngine day1 = new AVGEngine ();

	void Start (){
		nextButton.onClick.AddListener (OnClickNextButton);
		day1.FileLoad (@"F:\unity3D\RE-FinalFatDream\Assets\Data\NormalTalk.dat");
	}

	void Update (){
	
	}

	void OnClickNextButton(){
		dialog.text = day1.ProcessNextDialogFormat ().dialog;
	}
}

