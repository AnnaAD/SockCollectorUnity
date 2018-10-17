using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script will be on the player, allowing for the player to detect when it 
//is picking up a pick-upable item.
public class PickUpController : MonoBehaviour {

    private GameObject worldManager;

    private void Start() {
        worldManager = GameObject.Find("WorldManager");
    }

    //On every collision this method checks if the object colliding with
    //has the "PickUp" tag. If so, it deletes it on collision.
    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "PickUp") {
            //TODO: add scripts to update player inventory, stats, score, etc.
            PickUpInformation pickupInfo = collision.gameObject.GetComponent<PickUpInformation>();
            if (pickupInfo.getType() == "sock") {
                worldManager.GetComponent<PlayerData>().addSocks(pickupInfo.getValue());
            }
            Destroy(collision.gameObject);
        }
    }
}
