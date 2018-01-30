using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstance : MonoBehaviour {
	public int Level;

	// Use this for initialization
	void Start () {
		GameManager.CurrentLevel = Level;
		GameManager.GameManagerInstance = gameObject;
		GameManager.GameManagerInstanceScript = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
