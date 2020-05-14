using UnityEngine;
using System.Collections;
using TMPro;

public class NumberWizard : MonoBehaviour {
    [SerializeField] private int max;
    [SerializeField] private int min;
    [SerializeField] private TextMeshProUGUI guessText;
    private int _guess;
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Update is called once per frame
	void StartGame() {
		NextGuess();
	}

	void NextGuess(){
		_guess = Random.Range(min, max + 1);
		guessText.text = _guess.ToString();
    }

    public void OnPressHigher() {
	    if (_guess + 1 > max) return;
	    min = _guess + 1;
	    NextGuess();
    }
    
    public void OnPressLower() {
	    if (_guess - 1 < min) return;
	    max = _guess - 1;
	    NextGuess();
    }
    
}
