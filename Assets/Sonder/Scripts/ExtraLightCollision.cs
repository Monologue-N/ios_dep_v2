﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLightCollision : MonoBehaviour
{
 //private int bounceCount = 15;
	private string TAG = "[ExtraLightCollision] ";

	// void Start()
	// {
	// 	// destroy bullet after 5s
	// 	Destroy(gameObject, 5);
	// }


	// // called when hit surfaces
    // void OnCollisionEnter2D(Collision2D collision)
 	// {
 	// 	--bounceCount;
	// 	// bullet bounces up to 15 times
	// 	if (bounceCount == 0 && gameObject != null)
	// 	{
	// 		Destroy(gameObject);
	// 	}
 	// }

 	// called when hit star & moon 
 	void OnTriggerEnter2D(Collider2D collider)
 	{
		// when hit star
 		Star star = collider.GetComponent<Star>();
 		if (star != null)
 		{
            Destroy(gameObject);
 			star.Live();		
 		}   
 	}
}
