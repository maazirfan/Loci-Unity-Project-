using UnityEngine;
using System.Collections;
using UnityEngine.UI;



//This Script is written by Muhammad Maaz Irfan which is used for smoth movement of player from one point to another 
//It can be used easily in VR and also can be used for roalercoster kind of games 
//There are certain current points when user reach at that timer will popup for 10 sec and can be changed in unity edittor too 


public class lerp : MonoBehaviour {

	//for smooth movement 
	public Transform[] path;
	public float speed = 5.0f;
	public float reachDist = 1.0f;
	//specific defined path to follow
	public int currentPoint = 0;

	public GameObject SelectionPanel;
	//to start movement start has to be true other wise it wont run
	public	bool start;
	public UI skybx;

	public AudioSource Playbtn;
	public AudioSource[] AlertSound;



	//Timer displayed at speicific current points 
	private float timer;
	public Image _timerRef;
	public int startTime = 3;
	public Text timerText ;
	public bool entered;



	public GameObject GazePointerRing;

	public GameObject Video360sphere;


	public GameObject[] LociLoadImages;

	//already waiting is used to call for waiting part when timer comes up
	private bool alreadyWaiting = false;
	private bool alreadyWaitingPointTwo = false;
	private bool alreadyWaitingTwo = false;
	private bool alreadyWaitingThree = false;
	private bool alreadyWaitingfore = false;
	private bool alreadyWaitingFive = false;
	private bool alreadyWaitingSixPointOne = false;
	private bool alreadyWaitingSix = false;
	private bool alreadyWaitingSeven = false;
	private bool alreadyWaitingEight = false;

	//Rotation is used to rotate player movement at some specific point 
	public float rotateObj = -90;
	public float rotateObj1 = 34.6434f;


	//Restart Panel at the end of journey
	public GameObject RestartPanel;

	public GameObject[] videoPlayer;

	public GameObject Phone_Booth;


    public OVRInput vrs;
	// Use this for initialization
	void Start () {
		start = false;
		entered = true;
		timerText.enabled = false;

		GazePointerRing.SetActive (true);

		Video360sphere.SetActive (false);

		RestartPanel.SetActive (false);

		videoPlayer[0].SetActive (false);
		videoPlayer[1].SetActive (false);
		videoPlayer[2].SetActive (false);
		videoPlayer[3].SetActive (false);
		videoPlayer[4].SetActive (false);
		videoPlayer[5].SetActive (false);
		videoPlayer[6].SetActive (false);
		videoPlayer[7].SetActive (false);


			}






// Update is called once per frame
	void Update () {


		if (entered == true) 
		{
			
			timer -= Time.deltaTime;
			timerText.text = timer.ToString ("00");
			_timerRef.fillAmount = timer * 0.1f;
			if (timer <= 0) {
				timer = startTime;
				entered = false;
			}
		}
		





		
		if (start == true) {

			GazePointerRing.SetActive (false);

			Vector3 dir =   path [currentPoint].position - transform.position ;
			transform.position += dir * Time.deltaTime * speed;


			if (dir.magnitude <= reachDist)
			{
				currentPoint++;

			}


			if (currentPoint == 2 && !alreadyWaitingPointTwo) 
			{
				entered = true;
				timerText.enabled = true;


				StartCoroutine ("WaitPointTwo");     

			}

			if (currentPoint == 3 && !alreadyWaiting  ) 
			{
				
				entered = true;
				timerText.enabled = true;


				StartCoroutine ("Wait");     



			} 
		


			if (currentPoint == 5 && !alreadyWaitingTwo)
			{
				entered = true;
				timerText.enabled = true;
				StartCoroutine("WaitTwo");

			}


			if (currentPoint == 6 && !alreadyWaitingThree)
			{
				entered = true;
				timerText.enabled = true;
				StartCoroutine("WaitThree");
			}

			if (currentPoint == 8 && !alreadyWaitingfore)
			{
				//backgroundpoint9.SetActive (true);
				entered = true;
				timerText.enabled = true;
				StartCoroutine("Waitfore");
			}



			if (currentPoint == 10 && !alreadyWaitingFive)
			{
				//backgroundpoint9.SetActive (true);
				entered = true;
				timerText.enabled = true;
				StartCoroutine("Waitfive");
			}

			if (currentPoint == 11 && !alreadyWaitingSixPointOne ) 
			{
				transform.rotation = Quaternion.Euler(transform.rotation.x , transform.rotation.y+ rotateObj, transform.rotation.z);
				entered = true;
				timerText.enabled = true;
				StartCoroutine("WaitSixPointOne");
			}





			if (currentPoint == 13 && !alreadyWaitingSix)
			{
				
				//backgroundpoint9.SetActive (true);
				entered = true;
				transform.rotation = Quaternion.Euler(transform.rotation.x , transform.rotation.y+ rotateObj1, transform.rotation.z);
				timerText.enabled = true;
				StartCoroutine("WaitSix");
			}



			if (currentPoint == 14 && !alreadyWaitingSeven)
			{
				//backgroundpoint9.SetActive (true);
				entered = true;
				timerText.enabled = true;
				StartCoroutine("WaitSeven");
			}

			if (currentPoint == 15 && !alreadyWaitingEight)
			{
				//backgroundpoint9.SetActive (true);
				entered = true;
				timerText.enabled = true;
				StartCoroutine("WaitEight");
			}


			if (currentPoint == 16) 
			{
				RestartPanel.SetActive (true);
			}


			if(currentPoint>=path.Length)
			{
 		
				currentPoint = 21;
				start = false;
				GazePointerRing.SetActive (true);

			}

		}

		//GazePointerRing.SetActive (true);


	 


	}


IEnumerator	 Wait()
	{
		



			start = false;
		Video360sphere.SetActive (true);

		GetComponent<AudioSource> ().volume =0;

		//AlertSound[0].Play ();

		Debug.Log (entered + "entering in timer");
			alreadyWaiting = true;

			yield return new WaitForSeconds (10f);

		timerText.enabled = false;

		Video360sphere.SetActive (false);
		print (start);

		start = true;
		print (Time.time);

		GetComponent<AudioSource> ().volume =0.901f;
			alreadyWaiting = true;
				

	}
	IEnumerator	 WaitPointTwo()
	{




		start = false;
		//Video360sphere.SetActive (true);
		GazePointerRing.SetActive (true);

		LociLoadImages [0].SetActive (true);
		videoPlayer[0].SetActive (true);
		GetComponent<AudioSource> ().volume =0;

		//AlertSound[0].Play ();


		alreadyWaitingPointTwo = true;

		yield return new WaitForSeconds (10f);

		timerText.enabled = false;

		//Video360sphere.SetActive (false);
		print (start);
		GazePointerRing.SetActive (false);
		videoPlayer[0].SetActive (false);
		LociLoadImages [0].SetActive (false);
		start = true;
		print (Time.time);

		GetComponent<AudioSource> ().volume =0.901f;
		alreadyWaitingPointTwo = true;


	}
	IEnumerator	 WaitTwo()
	{


		start = false;

		videoPlayer[1].SetActive (true);

		LociLoadImages [1].SetActive (true);
		GetComponent<AudioSource> ().volume =0;

	//	AlertSound[1].Play ();
		alreadyWaitingTwo = true;
		yield return new WaitForSeconds (10f);
		timerText.enabled = false;

		LociLoadImages [1].SetActive (false);

		videoPlayer[1].SetActive (false);
		print (start);

		start = true;
		print (Time.time);

		GetComponent<AudioSource> ().volume =0.901f;
		alreadyWaitingTwo = true;



	}

	IEnumerator	 WaitThree()
	{


		start = false;
		GetComponent<AudioSource> ().volume =0;

		videoPlayer[2].SetActive (true);

		LociLoadImages [2].SetActive (true);
	//	AlertSound[2].Play ();
		alreadyWaitingThree = true;
		yield return new WaitForSeconds (10f);
		timerText.enabled = false;

		LociLoadImages [2].SetActive (false);
		videoPlayer[2].SetActive (false);

		print (start);

		start = true;
		print (Time.time);

		GetComponent<AudioSource> ().volume =0.901f;
		alreadyWaitingThree = true;



	}

	IEnumerator	 Waitfore()
	{


		start = false;


		GetComponent<AudioSource> ().volume =0;

		videoPlayer[3].SetActive (true);

		LociLoadImages [3].SetActive (true);
	//	AlertSound[3].Play ();
		alreadyWaitingfore = true;
		yield return new WaitForSeconds (10f);
		timerText.enabled = false;
		print (start);

		videoPlayer[3].SetActive (false);

		LociLoadImages [3].SetActive (false);
		start = true;
		print (Time.time);

		GetComponent<AudioSource> ().volume =0.901f;
		alreadyWaitingfore = true;



	}

	IEnumerator	 Waitfive()
	{


		start = false;
		GetComponent<AudioSource> ().volume =0;

		videoPlayer[4].SetActive (true);

		LociLoadImages [4].SetActive (true);
	//	AlertSound[4].Play ();
		alreadyWaitingfore = true;
		yield return new WaitForSeconds (10f);
		timerText.enabled = false;
		print (start);
		LociLoadImages [4].SetActive (false);

		videoPlayer[4].SetActive (false);

		start = true;
		print (Time.time);

		GetComponent<AudioSource> ().volume =0.901f;
		alreadyWaitingFive = true;



	}

	IEnumerator	 WaitSixPointOne()
	{


		start = false;
		GetComponent<AudioSource> ().volume =0;

		videoPlayer[5].SetActive (true);

		LociLoadImages [5].SetActive (true);
		//	AlertSound[5].Play ();
		alreadyWaitingSixPointOne = true;
		yield return new WaitForSeconds (10f);
		timerText.enabled = false;
		print (start);
		LociLoadImages [5].SetActive (false);

		videoPlayer[5].SetActive (false);

		start = true;
		print (Time.time);

		GetComponent<AudioSource> ().volume =0.901f;
		alreadyWaitingSixPointOne = true;



	}





	IEnumerator	 WaitSix()
	{


		start = false;
		GetComponent<AudioSource> ().volume =0;

		videoPlayer[5].SetActive (true);

		LociLoadImages [5].SetActive (true);
	//	AlertSound[5].Play ();
		alreadyWaitingfore = true;
		yield return new WaitForSeconds (10f);
		timerText.enabled = false;
		print (start);
		LociLoadImages [5].SetActive (false);

		videoPlayer[5].SetActive (false);

		start = true;
		print (Time.time);

		GetComponent<AudioSource> ().volume =0.901f;
		alreadyWaitingSix = true;



	}

	IEnumerator	 WaitSeven()
	{


		start = false;
		GetComponent<AudioSource> ().volume =0;

		videoPlayer[6].SetActive (true);

		LociLoadImages [6].SetActive (true);
	//	AlertSound[6].Play ();
		alreadyWaitingfore = true;
		yield return new WaitForSeconds (10f);
		timerText.enabled = false;
		print (start);
		LociLoadImages [6].SetActive (false);

		videoPlayer[6].SetActive (false);

		start = true;
		print (Time.time);

		GetComponent<AudioSource> ().volume =0.901f;
		alreadyWaitingSeven = true;



	}

	IEnumerator	 WaitEight()
	{


		start = false;
		GetComponent<AudioSource> ().volume =0;

		videoPlayer[7].SetActive (true);

		LociLoadImages [6].SetActive (true);
	//	AlertSound[7].Play ();
		alreadyWaitingfore = true;
		yield return new WaitForSeconds (10f);
		timerText.enabled = false;
		print (start);

		videoPlayer[7].SetActive (false);

		start = true;
		print (Time.time);

		GetComponent<AudioSource> ().volume =0.901f;
		alreadyWaitingEight = true;



	}








	/// <summary>
	//
	/// </summary>

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




	public void locationChngBtn()
	{		
		Playbtn.Play ();
				start = true;
				SelectionPanel.SetActive (false);

			skybx.RotateBtn = false;
		
		//skybx.RotateBtn = false;

	}







	public void locationbtn()
	{
		if (currentPoint == path.Length) 
		{
			start = true;
		}
	}
	}

