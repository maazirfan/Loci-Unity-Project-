using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;

public class skybox : MonoBehaviour {



	public Material[] secondSkybox;
	public static int i = 0;
	public GameObject SkyboxPanel;
    public MeshRenderer shadesImages;

    public Shader shader;
    public Shader shader1;
    public Renderer rend;



    void Start()
    {
        rend = GetComponent<Renderer>();
        shader1 = Shader.Find("Diffuse");

    }

    public void skyboxOn()
	{

		if (i == 0) {

		RenderSettings.skybox = secondSkybox[0];
			i++;
		}
		else if(i==1)
		{
			RenderSettings.skybox = secondSkybox[1];
			i++;
		}else if(i==2)
		{
			RenderSettings.skybox = secondSkybox[2];
			i=0;
		}

       // shadesImages.guiTexture = secondSkybox[0];
       

	}
    public void spherematerial()
    {
        rend.material.shader = shader1;
    }

	public void skyboxbtn1()
	{
		RenderSettings.skybox = secondSkybox[0];
	}
	public void skyboxbtn2()
	{
		RenderSettings.skybox = secondSkybox[1];
	}

	public void skyboxbtn3()
	{
		RenderSettings.skybox = secondSkybox[2];
        
	}

	public void PanelSkybox()
	{
		SkyboxPanel.SetActive (true);
	}

	public void ClosePanelSkybox()
	{
		SkyboxPanel.SetActive (false);
	}
}

