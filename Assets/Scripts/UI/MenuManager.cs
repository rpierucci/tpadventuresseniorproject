﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public void ToGame()
	{
		SceneManager.LoadScene ("Practice_level");
	}
	
	public void Quit()
	{
		Application.Quit();
	}
}
