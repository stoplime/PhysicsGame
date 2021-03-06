﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameManager {
	public static GameObject GameManagerInstance;
	public static GameInstance GameManagerInstanceScript;
	public static int CurrentLevel;

	public static Dictionary<string, KeyCode> KeyProfile = new Dictionary<string, KeyCode>()
	{
		{"forward", KeyCode.W}
		,{"backward", KeyCode.S}
		,{"left", KeyCode.A}
		,{"right", KeyCode.D}
		,{"leftClick", KeyCode.Mouse0}
		,{"rightClick", KeyCode.Mouse1}
	};
}
