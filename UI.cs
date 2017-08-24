 using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour {

	public GameObject MenuOptionPanel;
	public GameObject HelpPanel;
	public GameObject SelectionPanel;
	public float _Rotation = 180f;
	public float speed = 2f;
	public bool start;
	public bool RotateBtn;
	public AudioSource Playbtn;

	public float _skycolor = 2.4f;

	public GameObject[] spaceshiphoverbaord;
	public GameObject spaceshippanel;
	// Use this for initialization

	void Start () {
		
		RotateBtn = false;
		MenuOptionPanel.SetActive (false);
		HelpPanel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (RotateBtn == true) {
			RenderSettings.skybox.SetFloat ("_Rotation", Time.time *speed );
			//RenderSettings.skybox.SetFloat ("_Exposure", Mathf.Sin (Time.time * Mathf.Deg2Rad * 100) + 2);

		}
	}



	public void OptionBtn()
	{
		Playbtn.Play ();
		RotateBtn = true;
		spaceshippanel.SetActive (true);
		//MenuOptionPanel.SetActive (true);

	}
	public void helpPanelbBtn()
	{
		Playbtn.Play ();
		HelpPanel.SetActive (true);
	}
	public void helpPanelCloseBtn()
	{
		Playbtn.Play ();
		HelpPanel.SetActive (false);
	}

	public void SelectionSkyboxPanel()
	{
		Playbtn.Play ();
		SelectionPanel.SetActive (true);
	}

	public void CloseSkyboxPanel()
	{
		Playbtn.Play ();
		SelectionPanel.SetActive (false);
	}

	public void skyboxrotationOff()
	{
		Playbtn.Play ();
		RotateBtn = false;

	}


	public bool getskyboxRotationBtn()
	{
		Playbtn.Play ();
		RotateBtn = false;
		return RotateBtn;
	}

	public void spaceshipbtn()
	{
		Playbtn.Play ();
		spaceshiphoverbaord [0].SetActive (true);
		spaceshiphoverbaord [1].SetActive (false);
	}

	public void hoverboard()
	{
		Playbtn.Play ();
		spaceshiphoverbaord [1].SetActive (false);
		spaceshiphoverbaord [0].SetActive (false);
	}

	public void finalPanel()
	{
		Playbtn.Play ();
		spaceshippanel.SetActive (false);
		MenuOptionPanel.SetActive (true);
	}

	public void Restart()
	{
		Playbtn.Play ();
		SceneManager.LoadScene (0);
	}

}
