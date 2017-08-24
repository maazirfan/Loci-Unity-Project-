using UnityEngine;
using System.Collections;

public class camera_movement : MonoBehaviour {

	public GameObject testcube;



	// Use this for initialization
	void Start () 
	{
		testcube.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		RaycastHit hit;
		float theDistance; 
		//debus raycast is the editor 
		Vector3 forward = transform.TransformDirection (Vector3.forward) * 10;
		Debug.DrawRay (transform.position,forward,Color.green);
		if(Physics.Raycast(transform.position,(forward),out hit))
		{
			testcube.SetActive (true);
			theDistance = hit.distance;
			print (theDistance + "" + hit.collider.gameObject.name);
		}
	}

}
