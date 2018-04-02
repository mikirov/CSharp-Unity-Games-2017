using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.ShowMainMenu();
    }
    void ShowMainMenu() {
        Terminal.WriteLine("Choose difficulty");
        Terminal.WriteLine("1. Easy.");
        Terminal.WriteLine("2. Medium.");
        Terminal.WriteLine("3. Hard.");
        Terminal.WriteLine("Enter your selection:");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
