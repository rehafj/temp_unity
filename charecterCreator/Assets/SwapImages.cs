using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwapImages : MonoBehaviour
{
    public GameObject[] images = new GameObject[4];
    public Sprite[] headImages = new Sprite[9];
    public Sprite[] headTwoImages = new Sprite[9];
    public Sprite[] chestImages = new Sprite[9];
    public Sprite[] pantsImages = new Sprite[9];

    public Text headText;


    //images are head, lowerh, chest, pants --- 
    public int i = 0; 
    // Start is called before the first frame update
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            swapHead();
        }
    }

    public void swapHead() {
        Debug.Log("swap was asked for");
        if (i < 9 && i >=0)
        {
            if (i < 9)
            {
                i += 1;
            }
          
            images[0].GetComponent<SpriteRenderer>().sprite = headImages[i];
            setText(i);
        }
        else
        {
            images[0].GetComponent<SpriteRenderer>().sprite = headImages[0];
            i = 0;
        }

    }

    private void setText(int i )
    {
        switch (i)
        {
            case 1:
                headText.text = "Oh ohhhhh oh ohhhh *song* ";
                    break;
            case 3:
                headText.text = "I love coming over";
                break;
            case 8:
                headText.text = "Tere rare reta  *song* ";
                break;
            case 5:
                headText.text = "Nothing matter more than family";
                break;

            default:
                headText.text = "Nothing to say yet... ";

                break;

        }
       
    }
}
