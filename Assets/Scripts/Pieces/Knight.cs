using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Knight : Player

{
    void checkput()
    {
        hig.unable();
        hig.able((row-2),(col+1));
        hig.able((row-2),(col-1));
        hig.able((row-1),(col-2));
        hig.able((row-1),(col+2));
        hig.able((row+2),(col+1));
        hig.able((row+2),(col-1));
        hig.able((row+1),(col-2));
        hig.able((row+1),(col+2));
    }
    void move(){
            
        hig.movable((row-2),(col+1));
        hig.movable((row-2),(col-1));
        hig.movable((row-1),(col-2));
        hig.movable((row-1),(col+2));
        hig.movable((row+2),(col+1));
        hig.movable((row+2),(col-1));
        hig.movable((row+1),(col-2));
        hig.movable((row+1),(col+2));
        }
    void OnMouseDown()
    {   
        if(Active.player!=gameObject && Highlight.set.Contains(row+" "+col))
        {
            hig.unable();
            kill();
        }
        else if(Active.player==null){
            Active.player=gameObject;
            hig.player(row,col);
            move();
            
        }
        else{
            Active.player=null;
            ActiveCell.reset=true;
        }
    }

    void Update()
    { 

    }
        
}
