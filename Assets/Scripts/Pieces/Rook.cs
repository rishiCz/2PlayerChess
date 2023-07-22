using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rook : Player

{
    void checkput()
    {
        hig.unable();
         for(int i=row+1;i<8;i++)
            {   
                hig.able(i,col);
                if(ActiveCell.occupied[i,col]!=null)
                    break;
            }

            for(int i=row-1;i>-1;i--)
            {   
                
                hig.able(i,col);
                if(ActiveCell.occupied[i,col]!=null)
                    break;
            }
            for(int i=col+1;i<8;i++)
            {
                
                hig.able(row,i);
                if(ActiveCell.occupied[row,i]!=null)
                    break;
                
            }
            for(int i=col-1;i>-1;i--)
            {
                
                hig.able(row,i);
                if(ActiveCell.occupied[row,i]!=null)
                    break;
                
            }
    }
    void move(){
        for(int i=row+1;i<8;i++)
            {   
                hig.movable(i,col);
                if(ActiveCell.occupied[i,col]!=null)
                    break;
            }

            for(int i=row-1;i>-1;i--)
            {   
                
                hig.movable(i,col);
                if(ActiveCell.occupied[i,col]!=null)
                    break;
            }
            for(int i=col+1;i<8;i++)
            {
                
                hig.movable(row,i);
                if(ActiveCell.occupied[row,i]!=null)
                    break;
                
            }
            for(int i=col-1;i>-1;i--)
            {
                
                hig.movable(row,i);
                if(ActiveCell.occupied[row,i]!=null)
                    break;
                
            }
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