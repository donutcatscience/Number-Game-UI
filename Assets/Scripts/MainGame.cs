using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("Welcome to Number Game!");
        print("Pick a number in your head!");

        int max = 1000;
        int min = 1;

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than 500?");
        print("Up = higher, down = lower, return = equal.");

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            print("Up arrow pressed");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down Arrow Pressed");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Return Key Pressed");
        }
    }
}
