﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class failText : MonoBehaviour {
	// Use this for initialization
	void Start () {
		System.Threading.Thread.Sleep(600);
		string fail = Data.pickedMission.failDesc;
		Mission activeMission = Data.pickedMission;
		Text guiText1 = GameObject.Find("FailText").GetComponent<Text>();
		
		//guiText1.text = "Success \n" + success + "\n\nRewards: \n" + Data.pickedMission.rewardRsc.rscName;

		guiText1.text = fail;
		
		
		Text guiText2 = GameObject.Find("SquadList").GetComponent<Text> ();
		string names = "";
		for (int i = 0; i<Data.activeMissionChars.Count; i++) {
			Data.activeMissionChars [i].addExperience (100);
			names += Data.activeMissionChars [i].charName + " +100 XP \n";
			Data.activeMissionChars[i].setPicked();
		}
		
		guiText2.text = names;

		if (Data.dayCounter % 2 == 0 && Data.dayCounter != 0)
			Data.needCharacter = true;
		
		//at end of displaying messages clear activeMissionChars
		Data.activeMissionChars.Clear ();
		Data.currentCrewSize = 0;
		
		//update day counter
		Data.dayCounter++;
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
