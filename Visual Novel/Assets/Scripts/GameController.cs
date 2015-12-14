using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

	//Declared in Editor
	public GameObject guy;
	public GameObject girl;
	public GameObject sbGuy;
	public GameObject sbGirl;
	public GameObject sbText;

	int speaker;
	int number = 0;

	// Use this for initialization
	void Start () {
		//deactivate some GOs
		sbGuy.SetActive (false);
		sbGirl.SetActive (false);
		sbText.SetActive (false);
		speaker = 0;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("return")) {
			//print ("Enter key was pressed!");
			//do button press things 
			KeyPressed ();
		}
	}

	void KeyPressed(){
		//change speak bubble to guys
		if (speaker != 0) {
			sbGirl.SetActive (false);
			sbGuy.SetActive (true);
			sbText.SetActive (true);
			speaker = 0;
			//change text
			number++;
			sbText.GetComponent<Text> ().text = number.ToString();

		//change speak bubble to girls
		}else if (speaker != 1) {
			sbGuy.SetActive (false);
			sbGirl.SetActive (true);
			sbText.SetActive (true);
			speaker = 1;
			//change text
			number++;
			sbText.GetComponent<Text>().text = number.ToString();
		}
	}
}
