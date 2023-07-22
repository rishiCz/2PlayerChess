using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{   public Color white= new Color(0.9333334f,0.8901961f,0.7960785f);
    public Color black= new Color(0.5882353f,0.4941177f,0.4627451f);
    public Color yellow=new Color(1f,0.8705882f,0f,0.8f);

     GameObject cell;
     SpriteRenderer SR;
     string str;
     static public HashSet<string> set = new HashSet<string>();
     public HashSet<string> checkSet = new HashSet<string>();

    public void movable(int r,int c)
    {
        if((r<8&&r>-1)&&(c<8&&c>-1)&&((Active.player.tag=="Whites"&&Active.whiteT)||(Active.player.tag=="Blacks"&&!Active.whiteT)))
        {
            
            if(ActiveCell.occupied[r,c]!=null)
            {
                if(Active.player.tag!=ActiveCell.occupied[r,c].tag)
                {
                    canKill(r,c);
                }
            }
            else
            {
                string s =r+" "+c;
                cell=GameObject.Find(s);
                cell.GetComponent<BoxCollider2D>().enabled = true;
                SR=cell.GetComponent<SpriteRenderer>();
                SR.color=yellow;
                set.Add(s);
            }
        }
    }
    public void able(int r,int c){

        if((r<8&&r>-1)&&(c<8&&c>-1)){
            if(Active.whiteT)
            {
                ActiveCell.WhiteCheck[r,c]+=1;
            }
            else
            {
                ActiveCell.BlackCheck[r,c]+=1;
            }
            checkSet.Add(r+" "+c);
        }
        
    }
    public void unable(){
        foreach(string cname in checkSet)
        {
            int r=cname[0]-48;
            int c=cname[2]-48;
            if(Active.whiteT)
            {
                ActiveCell.WhiteCheck[r,c]-=1;
            }
        else
            {
                ActiveCell.BlackCheck[r,c]-=1;
            }
            
        }
        checkSet.Clear();
        
    }
    public void player(int r,int c){
        string s =r+" "+c;
        cell=GameObject.Find(s);
        SR=cell.GetComponent<SpriteRenderer>();
        SR.color=Color.blue;
        set.Add(s);
    }
    public void canKill(int r,int c)
    {
        string s =r+" "+c;
                cell=GameObject.Find(s);
                cell.GetComponent<BoxCollider2D>().enabled = true;
                SR=cell.GetComponent<SpriteRenderer>();
                SR.color=Color.red;
                set.Add(s);
    }
    public void reset(){
        foreach(string cname in set)
            {
                 
                cell=GameObject.Find(cname);
                cell.GetComponent<BoxCollider2D>().enabled = false;
                SR=cell.GetComponent<SpriteRenderer>();
                if(((int)cname[0]+(int)cname[2])%2==0)
                {
                    SR.color=black;
                }
                else
                {
                    SR.color=white;    
                }     
            }
            set.Clear();
            ActiveCell.reset=false;
    }

    void Update()
    {
        if(ActiveCell.reset)
        {
           reset();
        }
    }
}
