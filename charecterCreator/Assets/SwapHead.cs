using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapHead : MonoBehaviour
{


    public Sprite sp;
    public Sprite[] headImages = new Sprite[9];

    public int i=0;
    public Text headText;

    // Start is called before the first frame update
    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>().sprite;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            swap();
        }
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

            gameObject.GetComponent<SpriteRenderer>().sprite = headImages[i];
            setText(i);
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = headImages[0];
            i = 0;
        }




    }



    private void setText(int i)
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
