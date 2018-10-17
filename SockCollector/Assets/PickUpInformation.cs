using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script will be included on every pickup-able item. This will allow for 
//flexibility down the line in making more types of socks, power-ups, etc. 
public class PickUpInformation : MonoBehaviour {
    [SerializeField] private string type; //contains the pickup type.
    [SerializeField] private int value; //contains the value for the pickup.

    //makes the private type variable gettable by other scripts.
    public string getType() {
        return type;
    }

    //makes the private type variable gettable by other scripts.
    public int getValue() {
        return value;
    }
}
