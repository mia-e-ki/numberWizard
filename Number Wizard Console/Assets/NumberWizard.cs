using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
	int max = 1000;
	int min = 1;
	int guess = 500;

	public TMP_Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

	void StartGame () 
	{
		guess = 500;
		max = 1000;
		min = 1;

		Debug.Log("Welcome to Number Wizard!");
		Debug.Log("Pick a number..don't say it out-loud!");
		Debug.Log("The highest number is: " + max);
		Debug.Log("The lowest number is: " + min);
		Debug.Log("Tell me if your number is higher or lower than: " + guess);
		Debug.Log("Push Up = Higher, Push Down = Lower, Enter = Correct");
		max = max + 1;
	}

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a genius!");
			StartGame();
        }
    }

	void NextGuess()
	{
		guess = (max + min) / 2;
		if(	textComponent != null)
			textComponent.text = "Is your number " + guess + "?";
	}

	public void OnClickUp()
	{
			min = guess;
			NextGuess();
	}

	public void OnClickDown()
	{
		max = guess;
		NextGuess();
	}
}
