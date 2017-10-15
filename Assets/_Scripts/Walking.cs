﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour {

	private Animator anim;

//	public float speed = 1f;
//	public float rotationSpeed = 100.0f;

	public float vert;
	public float hori;
	public float sprint;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}


	// Update is called once per frame
	void Update () {
		vert = Input.GetAxis("Vertical");
		hori = Input.GetAxis("Horizontal");
		Sprinting();
		



//		if(Input.GetButtonDown("Jump")) {
//			anim.SetTrigger("isJumping");
//
//		}
//
//
//		float translation = Input.GetAxis("Vertical") * speed;
//        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
//        translation *= Time.deltaTime;
//        rotation *= Time.deltaTime;
//        transform.Translate(0, 0, translation);
//        transform.Rotate(0, rotation, 0);
//
//        if(translation != 0) {
//        	anim.SetBool("isRunning", true);
//        	anim.SetBool("isIdle", false);
//
//        } else {
//			anim.SetBool("isRunning", false);
//			anim.SetBool("isIdle", true);
//        }


	}

	void FixedUpdate () {
		anim.SetFloat("walk", vert);
		anim.SetFloat("Turn", hori);
		anim.SetFloat("run", sprint);

	}

	void Sprinting() {

		if(Input.GetButton("Fire1")){
			sprint = 0.2f;
		} else {
			sprint = 0.0f;
		}	
	}
}
