using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class URlImage : MonoBehaviour {

	public Image img;

	public string url;

	//test
	public Image[] imagess;
	public string[] urles;
	public bool start = false;

	// Use this for initialization

	void Start ()
	{
		start = false;

		if (start == true) 
		{
			StartCoroutine ("StartL");
		}


	}


	IEnumerator StartL ()
	{
		if (start == true) {

			WWW www = new WWW (url);
			yield return www;
			img.sprite = Sprite.Create (www.texture, new Rect (0, 0, www.texture.width, www.texture.height), new Vector2 (0, 0));



			WWW www1 = new WWW (urles [0]);
			yield return www1;
			imagess [0].sprite = Sprite.Create (www1.texture, new Rect (0, 0, www1.texture.width, www1.texture.height), new Vector2 (0, 0));

			WWW www2 = new WWW (urles [1]);
			yield return www2;
			imagess [1].sprite = Sprite.Create (www2.texture, new Rect (0, 0, www2.texture.width, www2.texture.height), new Vector2 (0, 0));

			WWW www3 = new WWW (urles [2]);
			yield return www3;
			imagess [2].sprite = Sprite.Create (www3.texture, new Rect (0, 0, www3.texture.width, www3.texture.height), new Vector2 (0, 0));


			WWW www4 = new WWW (urles [3]);
			yield return www4;
			imagess [3].sprite = Sprite.Create (www4.texture, new Rect (0, 0, www4.texture.width, 
				www4.texture.height), new Vector2 (0, 0));

			WWW www5 = new WWW (urles [4]);
			yield return www5;
			imagess [4].sprite = Sprite.Create (www5.texture, new Rect (0, 0, www5.texture.width, 
				www5.texture.height), new Vector2 (0, 0));

			WWW www6 = new WWW (urles [5]);
			yield return www6;
			imagess [5].sprite = Sprite.Create (www6.texture, new Rect (0, 0, www6.texture.width, 
				www6.texture.height), new Vector2 (0, 0));

			WWW www7 = new WWW (urles [6]);
			yield return www7;
			imagess [6].sprite = Sprite.Create (www7.texture, new Rect (0, 0, www7.texture.width, 
				www7.texture.height), new Vector2 (0, 0));

			WWW www8 = new WWW (urles [7]);
			yield return www8;
			imagess [7].sprite = Sprite.Create (www8.texture, new Rect (0, 0, www8.texture.width, 
				www8.texture.height), new Vector2 (0, 0));		

//			WWW www9 = new WWW (urles [8]);
//			yield return www9;
//			imagess [8].sprite = Sprite.Create (www9.texture, new Rect (0, 0, www9.texture.width, 
//				www9.texture.height), new Vector2 (0, 0)); 

//			WWW www10 = new WWW (urles [9]);
//			yield return www10;
//			imagess [9].sprite = Sprite.Create (www10.texture, new Rect (0, 0, www10.texture.width, 
//				www10.texture.height), new Vector2 (0, 0)); 



		}	

	}





	}


