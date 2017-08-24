using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class lociButton : MonoBehaviour {

	public GameObject LociImages;
	public GameObject BtnOn;
	public GameObject BtnOff;
	public bool _btnOn;
	//public Image locibtnImg;
	public Image[] lociimagesbtn;

	public static int i = 0;



	//audio 

	public AudioSource[] Lociaudioplay;
	public AudioClip[] LociAudioClip;

	//timer

	private float timer;
	public Image[] _timerRef;
	public int startTime = 3;

	public Text timerText;


	public bool entered;

	// Use this for initialization
	void Start () {
		




		timer = startTime;	
	}
	
	// Update is called once per frame
	void Update () {




	
	}


	public void LociBtnOn()
	{
		BtnOn.SetActive (false);
		BtnOff.SetActive (true);
					LociImages.SetActive (true);
		Lociaudioplay [0].Play ();


	}

	public void LociBtnOff()
	{
		
		LociImages.SetActive (false);
		BtnOff.SetActive (false);
		BtnOn.SetActive (true);


	}



	public void locibtn1()
	{
		entered = true;
		Lociaudioplay [0].Play ();

		lociimagesbtn [0].enabled = true;
		lociimagesbtn [1].enabled = false;
		lociimagesbtn [2].enabled = false;
		lociimagesbtn [3].enabled = false;

	}

	public void locibtn2()
	{

		entered = true;

		lociimagesbtn [1].enabled = true;



		Lociaudioplay [0].Stop ();
		Lociaudioplay [1].Play ();

		lociimagesbtn [0].enabled = false;

		lociimagesbtn [1].enabled = true;
		lociimagesbtn [2].enabled = false;
		lociimagesbtn [3].enabled = false;

	}

	public void locibtn3()
	{
		entered = true;

		lociimagesbtn [0].enabled = false;
		lociimagesbtn [1].enabled = false;




		Lociaudioplay [0].Stop ();
		Lociaudioplay [1].Stop ();
		Lociaudioplay [2].Play ();


		lociimagesbtn [2].enabled = true;
		lociimagesbtn [3].enabled = false;

	}

	public void locibtn4()
	{
		entered = true;

		lociimagesbtn [0].enabled = false;
		lociimagesbtn [1].enabled = false;
		lociimagesbtn [2].enabled = false;




		Lociaudioplay [0].Stop ();
		Lociaudioplay [1].Stop ();
		Lociaudioplay [2].Stop ();
		Lociaudioplay [3].Play ();



		lociimagesbtn [3].enabled = true;


	}

	public void locibtn5()
	{
		entered = true;

		lociimagesbtn [0].enabled = false;
		lociimagesbtn [1].enabled = false;
		lociimagesbtn [2].enabled = false;
		lociimagesbtn [3].enabled = false;



		Lociaudioplay [0].Stop ();
		Lociaudioplay [1].Stop ();
		Lociaudioplay [2].Stop ();
		Lociaudioplay [3].Stop ();
		Lociaudioplay [4].Play ();

		lociimagesbtn [4].enabled = true;



	}

	public void timerbtn()
	{
		entered = true;
		
	}





}
