using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pathFollower : MonoBehaviour {

	public Transform[] path;
	public float speed = 5.0f;
	public float reachDist = 1.0f;
	public int currentPoint = 0;

	public GameObject MainMenu;
	public GameObject Backgroundmodel;
	public GameObject spaceship;

	public AudioSource AlertSound;
	public AudioClip[] LociAudio;

	private bool alreadyWaiting = false;
	private bool alreadyWaitingTwo = false;
	private bool alreadyWaitingThree = false;
	private bool alreadyWaitingfore = false;


	private float timer;
	public Image _timerRef;
	public int startTime = 3;
	public Text timerText ;
	public bool entered;

	public float rotateObj = -90;
	public float rotateObj1 = 34.6434f;
	public	bool start;


	public GameObject RestartPanel;

	// Use this for initialization
	void Start () {
		start = false;
		entered = true;
		timerText.enabled = false;

		RestartPanel.SetActive (false);
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

		Vector3 dir =   path [currentPoint].position - transform.position ;

		transform.position += dir * Time.deltaTime * speed;



		if (dir.magnitude <= reachDist) {

			currentPoint++;

		}
			if (currentPoint == 1) 
			{
				//path [currentPoint].rotation =120;

				transform.rotation = Quaternion.Euler(transform.rotation.x , transform.rotation.y+ rotateObj, transform.rotation.z);

			}

			if (currentPoint == 3 && !alreadyWaiting  ) 
			{
				entered = true;
				timerText.enabled = true;
				StartCoroutine ("Wait");     



			} 
			if (currentPoint == 6 && !alreadyWaitingTwo)
			{
				entered = true;
				transform.rotation = Quaternion.Euler(transform.rotation.x , transform.rotation.y+ rotateObj1, transform.rotation.z);
				timerText.enabled = true;
				StartCoroutine("WaitTwo");

			}


			if (currentPoint == 7 && !alreadyWaitingThree)
			{
				entered = true;
				timerText.enabled = true;
				StartCoroutine("WaitThree");
			}

			if (currentPoint == 8 && !alreadyWaitingfore)
			{
				
				entered = true;
				timerText.enabled = true;
				StartCoroutine("Waitfore");
			}



			if (currentPoint == 11) 
			{
				RestartPanel.SetActive (true);
			}





		if(currentPoint>=path.Length)
		{

			currentPoint = 12;
				//Application.CaptureScreenshot ();
		}

	}
	}



	IEnumerator	 Wait()
	{



		start = false;
		GetComponent<AudioSource> ().volume =0;

		AlertSound.clip = LociAudio [0];
		AlertSound.Play ();

		Debug.Log (entered + "entering in timer");
		alreadyWaiting = true;

		yield return new WaitForSeconds (10f);
		timerText.enabled = false;
		print (start);

		start = true;
		print (Time.time);

		GetComponent<AudioSource> ().volume =0.901f;
		alreadyWaiting = true;


	}

	IEnumerator	 WaitTwo()
	{


		start = false;
		GetComponent<AudioSource> ().volume =0;
		alreadyWaitingTwo = true;
		yield return new WaitForSeconds (10f);
		timerText.enabled = false;
		print (start);

		start = true;
		print (Time.time);

		GetComponent<AudioSource> ().volume =0.901f;
		alreadyWaitingTwo = true;

//		AlertSound.Play ();

	}

	IEnumerator	 WaitThree()
	{


		start = false;
		alreadyWaitingThree = true;
		yield return new WaitForSeconds (10f);
		timerText.enabled = false;
		print (start);

		start = true;
		print (Time.time);


		alreadyWaitingThree = true;

		//AlertSound.Play ();

	}

	IEnumerator	 Waitfore()
	{


		start = false;
		alreadyWaitingfore = true;
		yield return new WaitForSeconds (10f);
		timerText.enabled = false;
		print (start);

		start = true;
		print (Time.time);


		alreadyWaitingfore = true;

		//AlertSound.Play ();

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


	public void locationChngBtn()
	{
		spaceship.SetActive (false);
		MainMenu.SetActive (false);
		start = true;
		Backgroundmodel.SetActive (false);
	}



	public void locationbtn()
	{
		if (currentPoint == path.Length) 
		{
			start = true;
		}
	}

}
