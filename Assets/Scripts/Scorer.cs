using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour {
    int hits = 0;
    int wallDamage = 1;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag != "Hit") {
            hits += wallDamage;
            Debug.Log("You hit the something " + hits + " times" );
        }
    }
}
