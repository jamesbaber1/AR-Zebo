using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    protected Joystick joystick;


	// Use this for initialization
	void Start () {
        joystick = FindObjectOfType<Joystick>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(joystick.Horizontal);
	}
}
