using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mopvingbg : MonoBehaviour
{
    public Material mt;
    public float timer = 2f;
    float exposure = 360;
    bool otherWay = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //timer -= Time.deltaTime;
        //if (timer < 0)
        //{
        //     timer = 0.5f;


        //}
        RenderSettings.skybox.SetFloat("_Rotation", exposure);

         if(exposure >= 0 && otherWay == false)
        {
            exposure -= 0.09f;
            if(exposure <= 1.5)
            {
                otherWay = true;
            }
        } else if(exposure <= 350)
        {
            exposure += 0.09f ;

            if (exposure >= 340.5)
            {
                otherWay = false;
            }
        } 

    }
}
