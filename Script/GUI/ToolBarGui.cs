using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolBarGui : MonoBehaviour {

	public List<Atom> Atoms;

	private Dictionary<string, Rect> boxes;

	// Use this for initialization
	void Start () {
		boxes = new Dictionary<string, Rect>();
	}
	
	// Update is called once per frame
	void Update () {
		// For Scalabilty purposes all rectangles will be generated here until a better solution arises
		boxes.Clear();
		float toolbarHeight = Screen.height/6;
		if (toolbarHeight < 100)
		{
			toolbarHeight = 100;
		}

		boxes.Add("ToolBar", new Rect(0, 0, Screen.width, toolbarHeight));
	}

	/// <summary>
	/// OnGUI is called for rendering and handling GUI events.
	/// This function can be called multiple times per frame (one call per event).
	/// </summary>
	void OnGUI()
	{
		GUI.Box(boxes["ToolBar"], "Atoms");

	}
}
