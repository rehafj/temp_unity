using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLICKME : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("clickme");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
