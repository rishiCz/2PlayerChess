using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cell : MonoBehaviour
{
    void OnMouseDown(){
        ActiveCell.cell=gameObject;
        Active.player.SendMessage("go");    
    }
}
