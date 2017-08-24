using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textureScript : MonoBehaviour {
    public Texture[] textures;
    
    public float changeInterval = 0.33F;
    public Renderer []rend;

    public Material abc;
    private MeshRenderer mate;

    public Shader shader1;
    void Start()
    {
        rend [0] = GetComponent<Renderer>();
        rend[1] = GetComponent<Renderer>();
        
    }

    void Update()
    {
        if (textures.Length == 0)
            return;
        
    }
    public void changeshaderbtn()
    {

        int index = Mathf.FloorToInt(Time.time / changeInterval);
        index = index % textures.Length;

        rend[0].material.mainTexture = textures[index];

        rend[1].material.mainTexture = textures[index];


        rend[0].material.shader = shader1;
        shader1 = Shader.Find("Diffuse");
        mate.material = abc;
    }

}
