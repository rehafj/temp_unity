using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapChest : MonoBehaviour
{
    public Sprite sp;
    public Sprite[] chestImages = new Sprite[9];
    public Text lhtext;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>().sprite;
    }

 

    public void swap()
    {
        Debug.Log("swap was asked for");
        if (i < 8 && i >= 0)
        {
            if (i < 8)
            {
                i += 1;
            }

            gameObject.GetComponent<SpriteRenderer>().sprite = chestImages[i]; setText(i);
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = chestImages[0];
            i = 0;
        }

    }
    private void setText(int i)
    {
        switch (i)
        {
            case 1:
                lhtext.text = "get a hold of your horse and relax *song*";
                break;
            case 3:
                lhtext.text = "Getting my famil, be right there";
                break;
            case 8:
                lhtext.text = "Riding his bike, red or white ?*song* \nWhite like a cup of cream!*song* ";
                break;
            case 5:
                lhtext.text = "Be thankful for what you have  ";
                break;

            default:
                lhtext.text = "Nothing to say yet... ";

                break;

        }

    }
}
