using System;
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
		LoadAtomIndexStats();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void LoadAtomIndexStats()
	{
		try
        {
            TextAsset txt = (TextAsset)Resources.Load("AtomStats", typeof(TextAsset));
            string content = txt.text;
            string[] fields = txt.text.Split('\t');

            // string name;
            // Creatures creatureType;
            // float health;
            // float damage;
            // float speed;
            // float price;
            // int inkcome;
            // int droppedInk;
            // //Starts at 7 because the first line is just a header.
            // for (int i = 7; i < fields.Length - 7; i += 7) //Is the last creature making it through?
            // {
            //     name = fields[i].Replace('\r', ' ').Replace('\n',' ').Trim();
            //     health = float.Parse(fields[i + 1]);
            //     damage = float.Parse(fields[i + 2]);
            //     speed = float.Parse(fields[i + 3]);
            //     price = float.Parse(fields[i + 4]);
            //     inkcome = int.Parse(fields[i + 5]);
            //     droppedInk = int.Parse(fields[i + 6]);
            //     creatureType = (Creatures)Enum.Parse(typeof(Creatures), name, true);

            //     if (creatures.ContainsKey(creatureType))
            //     {
            //         creatures[creatureType].creatureScript.maxHealth = health;
            //         creatures[creatureType].creatureScript.health = health;
            //         creatures[creatureType].creatureScript.damage = damage;
            //         creatures[creatureType].creatureScript.speed = speed;
            //         creatures[creatureType].creatureScript.price = price;
            //         creatures[creatureType].creatureScript.inkcomeValue = inkcome;
            //         creatures[creatureType].creatureScript.dropInk = droppedInk;
            //     }
            // }
        }
        catch(Exception e)
        {
            Debug.LogError("Error loading creature stats: " + e.Message);
        }
	}
}
