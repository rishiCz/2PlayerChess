using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{
    public static GameObject player=null;
    public static bool whiteT=true;
    public static bool place=false;
    public static List<GameObject> disabled=new List<GameObject>();

    public static void enableAll(){
        for(int i=0;i<disabled.Count;i++){
            disabled[i].SetActive(true);
        }
    }
    public static void clearAll(){
        disabled.Clear();
    }
  
}
