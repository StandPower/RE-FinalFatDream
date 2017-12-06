using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using System;
using System.IO;

public class AVGEngine{

	string[] allText;
	bool isJudgement;
	int lineIndex = 1;
	const int NORMAL_TALK = 1;
	const int CHOOSE_TALK = 2;
	const int JUMP_TALK = 3;
	delegate string CustomDialog(string type);

	List<string> LoadNextDialogFormat(){
		List<string> thisDialog = new List<string>();
		while (allText [lineIndex] != "") {
			thisDialog.Add (allText[lineIndex]);
			lineIndex += 1;
		}
		return thisDialog;
	}

	public DialogData ProcessNextDialogFormat(){
		List<string> thisLine = LoadNextDialogFormat ();
		int lineInDialog;
		if (isJudgement) {
			//AnalyzeDialog (thisLine[lineInDialog]);
			isJudgement = true;
		}
		return isNormalDialog (thisLine);
	}

	string AnalyzeDialog(string line){
		switch (line[0]) {
		case '-':
			return "isNormalDialog";
		case '.':
			return "";
		case '@':
			return "";
		case '$':
			return "";
		case '#':
			return "";
		default:
			return "";
		}
	}

	public void FileLoad(string fileName){
		allText = File.ReadAllLines(fileName);
	}
		

	DialogData isNormalDialog(List<string> dialog){
		DialogData data = new DialogData ();
		data.who = dialog [0].Substring (1);
		data.dialog = dialog [1];

		return data;
	}




}