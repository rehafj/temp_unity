using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapLegs : MonoBehaviour
{
    public Sprite sp;
    public Sprite[] legImages = new Sprite[9];
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

            gameObject.GetComponent<SpriteRenderer>().sprite = legImages[i];
            setText(i);
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = legImages[0];
            i = 0;
        }

    }

    private void setText(int i)
    {
        switch (i)
        {
            case 1:
                lhtext.text = "I’m holding it’s reins but its slipping *song* \n *song*";
                break;
            case 3:
                lhtext.text = "I really enjoyed coming here ";
                break;
            case 8:
                lhtext.text = "Make some room for him! *song* cz here he comes";
                break;
            case 5:
                lhtext.text = "and give to those less fortunate";
                break;

            default:
                lhtext.text = "Nothing to say yet... ";

                break;

        }

    }
}
