using UnityEngine;
using System.Collections;


public class Test_Animation_image : MonoBehaviour {

	#region first button movement
	public Transform[] path;
	public float speed = 5.0f;
	public float reachdist = 1.0f;
	public int currentPoint = 0;
	public	bool btnStart;
	public float rotateObj = -90; 
	#endregion 

	//another path for movement

	#region 2nd button movemet 
	public Transform[] path_2;
	public float speed_2 = 1f;
	public float reachdist_2 = 1f;
	public int currentPoint_2 = 0;
	public bool btnStart_2;
	public float rotateObj_2 = -90;
	#endregion 

	// another path for movement

	#region 3rd button movement

	public Transform [] path3;
	public float speed_3 = 1f;
	public float reachdist_3 =1f;
	public int currentPoint_3 =0;
	public bool btnStart_3;
	public float rotateObj_3 = -90;

    #endregion

    #region 4th  button movement
    public Transform[] path4;
    public float speed_4 = 1f;
    public float reachdist_4 = 1f;
    public int currentPoint_4 = 0;
    public bool btnStart_4;
    public float rotateObj_4 = -90;

    #endregion

    #region 5th  button movement
    public Transform[] path5;
    public float speed_5 = 1f;
    public float reachdist_5 = 1f;
    public int currentPoint_5 = 0;
    public bool btnStart_5;
    public float rotateObj_5 = -90;

    #endregion

    #region 6th  button movement
    public Transform[] path6;
    public float speed_6 = 1f;
    public float reachdist_6 = 1f;
    public int currentPoint_6 = 0;
    public bool btnStart_6;
    public float rotateObj_6 = -90;

    #endregion

    #region 7th  button movement
    public Transform[] path7;
    public float speed_7 = 1f;
    public float reachdist_7 = 1f;
    public int currentPoint_7 = 0;
    public bool btnStart_7;
    public float rotateObj_7 = -90;

    #endregion

    // Use this for initialization
    void Start () 
	{
		btnStart = false;
		btnStart_2 = false;
		btnStart_3 = false;
        btnStart_4 = false;
        btnStart_5 = false;
        btnStart_6 = false;
        btnStart_7 = false;
    }



	void Update()
	{
		#region code use for move object from position (x,y,z) to another pos
		//		if (animation_image [0] == true) 
		//		{
		//			Loci_Block [0].transform.Translate (Vector3.forward * Time.deltaTime * 5);
		//		}
		//
		//		if (Loci_Block[0].transform.position.z== 683f) 
		//		{
		//			Debug.Log ("stop point");
		//
		 //print (transform.position.x);
		//			animation_image[0] = false;
		//		}
		#endregion

		if (btnStart == true) 
		{
			Vector3 dir = path [currentPoint].position - transform.position;
			transform.position += dir * Time.deltaTime * speed;
		
			if (dir.magnitude <= reachdist) 
			{
				currentPoint++;

			}
			if (currentPoint == 1) 
			{
				transform.rotation = Quaternion.Euler(transform.rotation.x , transform.rotation.y+ rotateObj, transform.rotation.z);

				btnStart = false;
			}
		
		
		}


		if (btnStart_2 == true)
			
			{
			Vector3 dir = path_2 [currentPoint_2].position - transform.position;
			transform.position += dir * Time.deltaTime * speed;

			if (dir.magnitude <= reachdist_2 ) 
			{
				currentPoint_2++;

			}
			if (currentPoint_2 == 1) 
			{
				transform.rotation = Quaternion.Euler(transform.rotation.x , transform.rotation.y+ rotateObj, transform.rotation.z);

				btnStart_2 = false;
			}


			}


		if (btnStart_3 == true) 
		{
			Vector3 dir = path3 [currentPoint_3].position - transform.position;
			transform.position += dir * Time.deltaTime * speed;

			if (dir.magnitude <= reachdist_3) 
			{
				currentPoint_3 ++;
			}

			if (currentPoint_3 == 1) 
			{
				transform.rotation = Quaternion.Euler (transform.rotation.x, transform.rotation.y + rotateObj_3, transform.rotation.z);
			}

		}

        if (btnStart_4 == true)
        {
            Vector3 dir = path4[currentPoint_4].position - transform.position;
            transform.position += dir * Time.deltaTime * speed;

            if (dir.magnitude <= reachdist_4)
            {
                currentPoint_4++;
            }

            if (currentPoint_4 == 1)
            {
                transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y + rotateObj_4, transform.rotation.z);
            }

        }

        if (btnStart_5 == true)
        {
            Vector3 dir = path5[currentPoint_5].position - transform.position;
            transform.position += dir * Time.deltaTime * speed;

            if (dir.magnitude <= reachdist_5)
            {
                currentPoint_5++;
            }

            if (currentPoint_5 == 1)
            {
                transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y + rotateObj_5, transform.rotation.z);
            }

        }

        if (btnStart_6 == true)
        {
            Vector3 dir = path5[currentPoint_6].position - transform.position;
            transform.position += dir * Time.deltaTime * speed;

            if (dir.magnitude <= reachdist_6)
            {
                currentPoint_6++;
            }

            if (currentPoint_6 == 1)
            {
                transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y + rotateObj_6, transform.rotation.z);
            }

        }

        if (btnStart_7 == true)
        {
            Vector3 dir = path5[currentPoint_7].position - transform.position;
            transform.position += dir * Time.deltaTime * speed;

            if (dir.magnitude <= reachdist_7)
            {
                currentPoint_7++;
            }

            if (currentPoint_7 == 1)
            {
                transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y + rotateObj_7, transform.rotation.z);
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
					Gizmos.DrawSphere(path[i].position,reachdist);
				}
			}
	}








}
