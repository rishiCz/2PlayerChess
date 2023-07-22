using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveCell : MonoBehaviour
{
    public static GameObject cell=null;
    public static bool reset=false;
    public static GameObject[,] occupied=new GameObject[8,8];
    public static int[,] WhiteCheck=new int[8,8];
    public static int[,] BlackCheck=new int[8,8];
    
    void Start(){
        for(int i=0;i<8;i++){
            for(int j=0;j<8;j++){
                occupied[i,j]=null;
            }
        }
    }
}