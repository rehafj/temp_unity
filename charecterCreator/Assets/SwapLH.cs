using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapLH : MonoBehaviour
{
    public Sprite sp;
    public Sprite[] lhImages = new Sprite[9];

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
        if (i < 9 && i >= 0)
        {
            if (i < 9)
            {
                i += 1;
            }

            gameObject.GetComponent<SpriteRenderer>().sprite = lhImages[i];
            setText(i);
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = lhImages[0];
            i = 0;
        }

    }




    private void setText(int i)
    {
        switch (i)
        {
            case 1:
                lhtext.text = "our moon, the great and beautiful *song*";
                break;
            case 3:
                lhtext.text = "Lunch ? Ofc I’ll come over!*";
                break;
            case 8:
                lhtext.text = "Daddy when are you coming home*song* \nDad’s arriving  at six *song*";
                break;
            case 5:
                lhtext.text = "You are all loved equally ";
                break;

            default:
                lhtext.text = "Nothing to say yet... ";

                break;

        }

    }
}
