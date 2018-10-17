using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A script on the worldmanager object, which will remain between scenes while
//player and other objects do not.

public class PlayerData : MonoBehaviour {
    //a variable to keep track of all the socks a player has.
    private int socks;


    public void addSocks(int socks) {
        this.socks += socks;
    }

    public int getSocks() {
        return socks;
    }
	
}
