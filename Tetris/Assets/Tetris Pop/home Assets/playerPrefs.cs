using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPrefs : MonoBehaviour {

	// Use this for initialization
	void Start () {
		setAllPlayerPrefs ();
	}
	
	public void setAllPlayerPrefs () {
		if(!PlayerPrefs.HasKey("sfx"))
			PlayerPrefs.SetInt ("sfx", 1);				//sfx sound is on
		if(!PlayerPrefs.HasKey("music"))
			PlayerPrefs.SetInt ("music", 1);            //music sound is on
        if (!PlayerPrefs.HasKey("currentLevel"))
            PlayerPrefs.SetInt("currentLevel", 1);         //current level is level 1
    }

    public void resetAllPlayerPrefs () {
		PlayerPrefs.SetInt ("sfx", 1);				//reset sfx sound
		PlayerPrefs.SetInt ("music", 1);            //reset music sound
        PlayerPrefs.SetInt("currentLevel", 1);         //reset current level
    }
}
