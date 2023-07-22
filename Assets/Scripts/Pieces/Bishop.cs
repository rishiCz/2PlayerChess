using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bishop : Player

{
    void checkput()
    {
        hig.unable();
         for(int i=1;i<8;i++)
            {   int r=row+i;
                int c=col+i;
                
                hig.able(r,c);
                if((r<8&&r>-1)&&(c<8&&c>-1)&& ActiveCell.occupied[r,c]!=null)
                    break;
            }

            for(int i=1;i<8;i++)
            {   
                int r=row-i;
                int c=col+i;
                
                hig.able(r,c);
                if((r<8&&r>-1)&&(c<8&&c>-1)&&ActiveCell.occupied[r,c]!=null)
                    break;
            }
            for(int i=1;i<8;i++)
            {
                int r=row+i;
                int c=col-i;
                
                hig.able(r,c);
                if((r<8&&r>-1)&&(c<8&&c>-1)&&ActiveCell.occupied[r,c]!=null)
                    break;
                
            }
            for(int i=1;i<8;i++)
            {
                int r=row-i;
                int c=col-i;
                
                hig.able(r,c);
                if((r<8&&r>-1)&&(c<8&&c>-1)&&ActiveCell.occupied[r,c]!=null)
                    break;
                
            }
    }
    void move()
    {
        moveDiagonal();
    }
    protected void moveDiagonal(){
        for(int i=1;i<8;i++)
            {   int r=row+i;
                int c=col+i;
                
                hig.movable(r,c);
                if((r<8&&r>-1)&&(c<8&&c>-1)&& ActiveCell.occupied[r,c]!=null)
                    break;
            }

            for(int i=1;i<8;i++)
            {   
                int r=row-i;
                int c=col+i;
                
                hig.movable(r,c);
                if((r<8&&r>-1)&&(c<8&&c>-1)&&ActiveCell.occupied[r,c]!=null)
                    break;
            }
            for(int i=1;i<8;i++)
            {
                int r=row+i;
                int c=col-i;
                
                hig.movable(r,c);
                if((r<8&&r>-1)&&(c<8&&c>-1)&&ActiveCell.occupied[r,c]!=null)
                    break;
                
            }
            for(int i=1;i<8;i++)
            {
                int r=row-i;
                int c=col-i;
                
                hig.movable(r,c);
                if((r<8&&r>-1)&&(c<8&&c>-1)&&ActiveCell.occupied[r,c]!=null)
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