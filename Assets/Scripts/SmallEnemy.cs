﻿using UnityEngine;
using System.Collections;

public class SmallEnemy : MonoBehaviour {

	
	private bool movingLeft = true;
	private float moveSpeed = 52.0f;
	public Sprite left;
	public Sprite right;
	//public Sprite center;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (movingLeft) {
			transform.position += Vector3.left * moveSpeed * Time.deltaTime;
		} else {
			transform.position += Vector3.right * moveSpeed * Time.deltaTime;
		}
		
	}
	
	void OnTriggerEnter2D (Collider2D collider){
		
		if (collider.gameObject.CompareTag ("RobotTrigger") ) {
			
			if (movingLeft) {
				GetComponent<SpriteRenderer>().sprite = right;
				movingLeft = false;
			} else {
				GetComponent<SpriteRenderer>().sprite =  left;
				movingLeft = true;
			}
		}
	}
}