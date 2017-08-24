using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class NewBehaviourScript : MonoBehaviour {


	public Transform[] path;
	public float speed = 5.0f;
	public float reachDist = 1.3f;
	public int Current_Point = 0;
	public bool start;



	private float timer;
	public Image _timer_Ref;
//	public int Start_Time = 10;
	public int Start_Time;
	public bool entered; 
	public Text Timer_Text;

	public bool waitingActive;

	public GameObject[] videoplayer;
	public GameObject Phone_Booth;
	public GameObject[] LociTest;

	public GameObject[] L_buttons;

	public MediaPlayerCtrl scrMedia;

	public MeshRenderer testMaterial;

    public GameObject die;
	void Start () 
	{
		start = false;
		entered = true;
		Timer_Text.enabled = false;

		videoplayer [0].SetActive (false);
		videoplayer [1].SetActive (false);
//		videoplayer [2].SetActive (false);
	
		 


	}
	

	void Update () 
	{
		
	
		if (entered == true) 
		{
			timer -= Time.deltaTime;
			Timer_Text.text = timer.ToString("00");
			_timer_Ref.fillAmount = timer * 0.1f;

			if (timer <= 0 && timer <= 10 ) 
			{
				



				entered = false;
			}


			
		}


		if (start == true) 
		{
			Vector3 dir = path [Current_Point].position - transform.position;
			transform.position += dir * Time.deltaTime * speed;

			if (dir.magnitude <= reachDist) 
			{
				Current_Point++;
			}

			if (Current_Point == 1) 
			{
				start = true;
				//entered = true;
			}

			if (Current_Point == 2 && !waitingActive) 
			{
				
				StartCoroutine ("waiting");
			}


		

		
		}

        


	}


	IEnumerator waiting()
	{	waitingActive = true;
		entered = true;
		start = false;
		Timer_Text.enabled = true;
		Start_Time = 5;
		timer = Start_Time;
		yield return new WaitForSeconds(10f);
		start = true;

	}

	IEnumerator waitingOne()
	{
		waitingActive = true; 
		entered = true;
		start = false;
		Timer_Text.enabled = true;
		videoplayer [0].SetActive (true);
		yield return("waitingOne");
	}

	IEnumerator waitingTwo()
	{
		entered = true;
		print (entered);
		start = false;
		Timer_Text.enabled = true;
		videoplayer [1].SetActive (true);
		yield return ("waitingTwo");
		yield return new WaitForSeconds (29f);			
	}


	IEnumerator Wait()
	{
		//
		scrMedia.Play();
		//
		waitingActive = true;
		entered = true;
		L_buttons [0].SetActive (false);
		L_buttons [1].SetActive (false);
		start = false;
		Timer_Text.enabled = true;
		videoplayer [1].SetActive (true);
		Start_Time = 25;
		timer = Start_Time;
		yield return new WaitForSeconds (20f);
		print (Time.time);
		L_buttons [1].SetActive (true);

		//
		scrMedia.Stop ();
		//
		videoplayer [1].SetActive (false);
		Timer_Text.enabled = false;

		  
	}


	IEnumerator WaitTest()
	{
		waitingActive = true;
		entered = true;
		L_buttons [1].SetActive (false);
		start = false;
		Timer_Text.enabled = true;
		videoplayer [1].SetActive (true);
		Start_Time = 20;
		timer = Start_Time;
		yield return new WaitForSeconds (20f);
		print (Time.time);
		L_buttons [0].SetActive (true);
		videoplayer [1].SetActive (false);
		Timer_Text.enabled = false;
	}





	public void btn1()
	{
		//StartCoroutine ("waiting");
		StartCoroutine ("Wait");
	}
	public void btn2()
	{
		//StartCoroutine ("waitingOne");
		StartCoroutine ("WaitTest");
	}

	public void btn3()
	{
		StartCoroutine ("waitingTwo");
	}



}
