using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour

{
    protected GameObject cell;
    public Highlight hig;
    public int row;
    public int col;
    public int srow;
    public int scol;
    
    
    void Start()
    {   
        srow=row;
        scol=col;
        resetAll();   
    }

    protected void kill(){
        ActiveCell.cell=GameObject.Find(row+" "+col);
        Active.player.SendMessage("go");
        Active.disabled.Add(gameObject);
        gameObject.SetActive(false);
        
    }

    public void go(){
        ActiveCell.occupied[row,col]=null;
        row=ActiveCell.cell.name[0]-48;
        col=ActiveCell.cell.name[2]-48;
        ActiveCell.occupied[row,col]=gameObject;
        cell=ActiveCell.cell;
        transform.position=new Vector3(cell.transform.position.x, cell.transform.position.y, transform.position.z);
        ActiveCell.cell=null;
        Active.place=true;
        Active.player.SendMessage("checkput");
        Active.player=null;
        Active.whiteT=!Active.whiteT;
        hig.reset();
        Debug.Log("White"+ ActiveCell.WhiteCheck[7,3]);
        Debug.Log("Black"+ ActiveCell.WhiteCheck[0,4]);
        Timers.resetTime();
        Timers.timeon=true;
    }
    public void resetAll(){
        Active.clearAll();
        ActiveCell.occupied[row,col]=null;
        row=srow;
        col=scol;
        cell=GameObject.Find(row+" "+col);
        ActiveCell.occupied[row,col]=gameObject;
        hig=new Highlight();   
        Vector3 pos =new Vector3(cell.transform.position[0],cell.transform.position[1],transform.position[2]);
        transform.position = pos; 
        gameObject.SetActive(true);
        ActiveCell.cell=null;
        Active.player=null;
        Active.whiteT=true;
        Timers.stop();  
    }
        
}
