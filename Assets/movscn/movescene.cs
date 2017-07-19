using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class movescene : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void Loadmain(){
		if(Input.touchCount>0){
			SceneManager.LoadScene ("main");
}
	}
}