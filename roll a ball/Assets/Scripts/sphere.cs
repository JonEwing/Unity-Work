using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sphere : MonoBehaviour {

	public float Speed;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	void Start () 
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
	}
	
	// Update is called once per frame
	void Update () 
	{

		Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f,Input.GetAxis("Vertical"));
		rb.AddForce (movement * Speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("pickups"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}

	void SetCountText()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 12){
			winText.text = "You Win!";
	}
			
	}
}
