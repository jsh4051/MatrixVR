﻿using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void start()
	{
	}
	public void Clicked()
	{
		Application.LoadLevel ("SceneEarth");
		//this.renderer.material.color.a = 1f;	
	}
	public void Pointed()
	{
		//this.renderer.enabled = false;
		//Vector3 tempscale;
		//tempscale.x = scale.x * 2;
		//tempscale.y = scale.y * 2;
		//tempscale.z = scale.z * 2;
		Color temp = this.renderer.material.color;
		temp.a = 1f;
		this.renderer.material.color = temp;
		this.transform.localScale = new Vector3 (3f, 3f, 3f);
	}
	public void PointedOut()
	{
		//this.renderer.enabled = false;
		Color temp = this.renderer.material.color;
		temp.a = 0.3f;
		this.renderer.material.color = temp;
		this.transform.localScale = new Vector3 (2.5f, 2.5f, 2.5f);
	}
}
