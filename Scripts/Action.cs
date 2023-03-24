using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void Waving()
    {
        anim.SetBool("Waving",true);
        anim.SetBool("HipHop", false);
        anim.SetBool("HouseDance", false);
        anim.SetBool("SillyDance", false);
    }

    public void HipHop()
    {
        anim.SetBool("HipHop", true);
        anim.SetBool("Waving", false);
        anim.SetBool("HouseDancing", false);
        anim.SetBool("SillyDance", false);
    }

    public void HouseDance()
    {
        anim.SetBool("HouseDancing", true);
        anim.SetBool("Waving", false);
        anim.SetBool("HipHop", false);
        anim.SetBool("SillyDance", false);
    }
    public void SillyDance()
    {
        anim.SetBool("SillyDance", true);
        anim.SetBool("Waving", false);
        anim.SetBool("HouseDancing", false);
        anim.SetBool("HipHop", false);
    }
}
