﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaileJugador2 : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Repeticion.repeticiones == 0){
            anim.SetTrigger("Final");
        }
	}
}
