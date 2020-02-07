using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class home : MonoBehaviour {
    public string facebook;
    public string google;
    public string twitter;
    public GameObject info_menu;
	public GameObject option_menu;
	public AudioSource bgMusic;

	// Use this for initialization
	void Start () {
			if(PlayerPrefs.GetInt("music")==1)
					bgMusic.Play();
	}
		
	// Update is called once per frame
	public void gotoGame() {
				Application.LoadLevel("game");
	}

	public void showInfo(){
			Camera.main.GetComponent<Blur>().enabled = true;
			info_menu.SetActive(true);

	}
	public void showOption(){
			Camera.main.GetComponent<Blur>().enabled = true;
			option_menu.SetActive(true);

	}
		
	public void store(){
			Application.LoadLevel("store");
	}

	public void close(){
			Camera.main.GetComponent<Blur>().enabled = false;
			info_menu.SetActive(false);
			option_menu.SetActive(false);
	}
    public void _google(){
        Application.OpenURL(google);
    }
    public void _facebook()
    {
        Application.OpenURL(facebook);
    }
    public void _twitter()
    {
        Application.OpenURL(twitter);
    }
}
