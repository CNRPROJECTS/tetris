using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class option : MonoBehaviour {
		public GameObject[] disableIcon;
		playerPrefs pp = new playerPrefs();
		public AudioSource bgMusic;
	// Use this for initialization
	void Start () {
				disableIcon [1].SetActive ((PlayerPrefs.GetInt ("sfx")==1)?false:true);
				disableIcon [0].SetActive ((PlayerPrefs.GetInt ("music")==1)?false:true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void music () {
			if (PlayerPrefs.GetInt ("music") == 0) {
						PlayerPrefs.SetInt ("music", 1);			//music sound is on
						disableIcon [0].SetActive (false);			//disable icon is deactivate
						bgMusic.Play();
			}else{
						PlayerPrefs.SetInt ("music", 0);			//music sound is off
						disableIcon [0].SetActive (true);			//disable icon is activate
						bgMusic.Pause();
			}
	}

	public void sfx () {
			if (PlayerPrefs.GetInt ("sfx") == 0) {
						PlayerPrefs.SetInt ("sfx", 1);				//sfx sound is on
						disableIcon [1].SetActive (false);			//disable icon is deactivate
			}else{
						PlayerPrefs.SetInt ("sfx", 0);				//sfx sound is off
						disableIcon [1].SetActive (true);			//disable icon is activate
			}
	}
				

	public void reset () {
				PlayerPrefs.DeleteAll ();
				pp.resetAllPlayerPrefs ();
	}
}
