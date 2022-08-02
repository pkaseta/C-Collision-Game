using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    //Movement Speed variable
    [SerializeField] float moveSpeed = 15f;

    // Start is called before the first frame update
    void Start() {
       PrintInstructions();
    }

    // Update is called once per frame
    void Update() {
        MovePlayer();
    }

    void PrintInstructions() {
        Debug.Log("Wlcome to the game");
        Debug.Log("This game is awesome");
        Debug.Log("Move player with WASD keys");
        Debug.Log("Do not hit the walls!");
    }

    void MovePlayer(){
        //Movement Variables
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float yValue = 0.0f;

        transform.Translate(xValue, yValue, zValue);
    }
}
