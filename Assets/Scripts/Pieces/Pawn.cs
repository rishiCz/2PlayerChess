using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pawn : Player

{       
        void checkput()
        {
            hig.unable();
            int i=1;
            if(tag=="Whites")                
            i=-1;
            int r=row+i;
            int c=col+i;
            if((r<8&&r>-1)&&(c<8&&c>-1))
                hig.able(r,c);
            c=col-i;
            if((r<8&&r>-1)&&(c<8&&c>-1))
                hig.able(r,c);
        }

        void move(){
            int i=1;
        if(tag=="Whites")                
            i=-1;
        int r=row+i;
        int c=col;
        if((r<8&&r>-1)&&(c<8&&c>-1)&&ActiveCell.occupied[row+i,col]==null)
            hig.movable((row+i),(col));
        if(srow==row&&scol==col&&ActiveCell.occupied[row+i+i,col]==null)
            hig.movable((row+i+i),(col));
        
        r=row+i;
        c=col+i;
        if((r<8&&r>-1)&&(c<8&&c>-1)&&ActiveCell.occupied[r,c]!=null && ActiveCell.occupied[r,c].tag!=tag &&((Active.player.tag=="Whites"&&Active.whiteT)||(Active.player.tag=="Blacks"&&!Active.whiteT)))
            hig.canKill(r,c);
        c=col-i;
        if((r<8&&r>-1)&&(c<8&&c>-1)&&ActiveCell.occupied[r,c]!=null && ActiveCell.occupied[r,c].tag!=tag &&((Active.player.tag=="Whites"&&Active.whiteT)||(Active.player.tag=="Blacks"&&!Active.whiteT)))
            hig.canKill(r,c);
        
       
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
