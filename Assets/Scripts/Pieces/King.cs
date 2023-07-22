using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class King : Player

{
    void move()
    {
        hig.movable(row,col+1);
        hig.movable(row,col-1);
        hig.movable(row+1,col);
        hig.movable(row-1,col);
        hig.movable(row+1,col+1);
        hig.movable(row+1,col-1);
        hig.movable(row-1,col+1);
        hig.movable(row-1,col-1);
    }
    void checkput()
    {
        hig.unable();
        hig.able(row,col+1);
        hig.able(row,col-1);
        hig.able(row+1,col);
        hig.able(row-1,col);
        hig.able(row+1,col+1);
        hig.able(row+1,col-1);
        hig.able(row-1,col+1);
        hig.able(row-1,col-1);
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
    void isCheck()
    {
        if(tag=="Whites")
        {
            if(ActiveCell.BlackCheck[row,col]>1)
                Debug.Log("White Check");
        }
        else
        {
            if(ActiveCell.WhiteCheck[row,col]>1)
                Debug.Log("Black Check");
        }
    }
  void Update()
    {  
        // isCheck();
    }
        
}
