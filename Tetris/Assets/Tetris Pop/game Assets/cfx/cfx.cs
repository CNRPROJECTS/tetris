using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cfx : MonoBehaviour {
    public int whichone;
    public Animator animatorController;
	public Vector2 pos;
    public GameObject efx;
    public Texture[] effectTexture;
	// Use this for initialization
	void Start () {
        StartCoroutine("destroyer");
		this.transform.position = pos;
        efx.GetComponent<Renderer>().material.mainTexture = effectTexture[whichone];
	}
    public IEnumerator destroyer()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update () {
		this.transform.position = pos;
	}
}
