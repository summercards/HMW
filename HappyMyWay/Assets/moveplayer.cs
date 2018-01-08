using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplayer : MonoBehaviour {

	public float m_speed = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		move ();		
	}

	void move()	{
		if (Input.GetKey(KeyCode.W)|Input.GetKey(KeyCode.UpArrow)) 
		{			
			this.transform.Translate(Vector3.forward*m_speed*Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.DownArrow)) 
		{
			this.transform.Translate(Vector3.forward *- m_speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow)) 
		{
			this.transform.Translate(Vector3.right *-m_speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow)) 
		{
			this.transform.Translate(Vector3.right * m_speed * Time.deltaTime);
		}
	}
}
