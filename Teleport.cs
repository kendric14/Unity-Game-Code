using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget; // Variable f�r Teleport position
    public GameObject thePlayer; // Variable f�r den Spielerobjekt
    private void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
        // Trigger der beide positionen gleich schaltet
    }
}
