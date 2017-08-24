using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class testpoistion : MonoBehaviour {

    public string[] url ;
   
    public Material[] obj;



    IEnumerator Start()
    {
        
        WWW www0 = new WWW(url[0]);
        yield return www0;
        Renderer renderer = GetComponent<Renderer>();

        renderer.material.mainTexture = www0.texture;   
        obj[0].mainTexture = www0.texture;
        // obj[0].mainTe2xture = Texture2d.Create(www.texture,new Rect(0,0, www.texture.width,www.texture.height),new Vector2(0,0)));
       

        WWW www1 = new WWW(url[1]);
        yield return www1;
        renderer.material.mainTexture = www1.texture;
        obj[1].mainTexture = www1.texture;
      

      
        WWW www2 = new WWW(url[2]);
        yield return www2;
        renderer.material.mainTexture = www2.texture;
        obj[2].mainTexture = www2.texture;
   

   
        WWW www3 = new WWW(url[3]);
        yield return www3;
        renderer.material.mainTexture = www3.texture;
        obj[3].mainTexture = www3.texture;
    

        WWW www4 = new WWW(url[4]);
        yield return www4;
        renderer.material.mainTexture = www4.texture;
        obj[4].mainTexture = www4.texture;

        WWW www5 = new WWW(url[5]);
        yield return www5;
        renderer.material.mainTexture = www5.texture;
        obj[5].mainTexture = www5.texture;

        WWW www6 = new WWW(url[6]);
        yield return www5;
        renderer.material.mainTexture = www5.texture;
        obj[6].mainTexture = www6.texture;



    }

}
  

