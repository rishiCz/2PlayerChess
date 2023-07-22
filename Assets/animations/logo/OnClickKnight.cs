using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickKnight : MonoBehaviour
{
    public Animator anim;
    public Animator anim2;
    public bool play=false;
    
    void OnMouseDown()
    {
        play=true; 
        anim.SetBool("touched",play);
        anim2.SetBool("touched",play);  
    }
    public void disable(){
        play=false;
        anim.SetBool("touched",play);
        anim2.SetBool("touched",play);
    }
    void Update(){
        
    }
}
