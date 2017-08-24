using UnityEngine;
using System.Collections;

public class navmesh : MonoBehaviour {

	// Use this for initialization
	public Transform[] path;
	public float speed = 5;
	public int currentPoint = 0;
	public float reachDist = 1.0f;
	public float waitpoint = 5f;
	//public GameObject btn;
	public	bool start;
	public bool Set;

	private bool alreadyWaiting = false;
	private bool alreadyWaitingTwo = false;


	void Start(){
		start = false;

		Set = false;
	}	


	void Update  () {

		if (Set == true) {

			Vector3 dir =   path [currentPoint].position - transform.position ;
			transform.position  += dir * Time.deltaTime * speed;

			if (dir.magnitude <= reachDist) {

				currentPoint++;


				if (currentPoint ==3 && !alreadyWaiting)
				{ 
					StartCoroutine ("Wait");    

								
				}

				}

		

			if(currentPoint>=path.Length)
			{				
				currentPoint = 4;

			//btn.SetActive (false);

			}

		}

	 
}


	void OnDrawGizmos()
	{
		if(path.Length > 0)
			for (int i = 0; i < path.Length; i++) 
			{
				if(path[i] !=null)
				{
					Gizmos.DrawSphere(path[i].position,reachDist);
				}
			}
	}




	IEnumerator	 Wait()
	{


		start = false;
		Set = false;
		alreadyWaiting = true;
		Debug.Log ("timer start");
		yield return new WaitForSeconds (10f);
		Debug.Log ("hey");
		print (start);
		Set = true;
		start = true;
		print (Time.time);


		alreadyWaiting = true;

	
	}

	IEnumerator	 WaitTwo()
	{


		start = false;
		alreadyWaitingTwo = true;
		yield return new WaitForSeconds (10f);
		print (start);

		start = true;
		print (Time.time);


		alreadyWaitingTwo = true;



	}









	public void waitBtn()
	{
		if (start = true) 
		{
			Time.timeScale = 1;
		}
	}

	public void StartBtn()
	{
		Set = true;	
	}



}

