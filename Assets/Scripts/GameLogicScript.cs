using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogicScript : MonoBehaviour {

	public Transform treasure;
	public Transform trees; 
	public Transform rock; 
	public Transform startingPoint; 
	public Transform player;
	public Text myText;


	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// starting point
		if ((startingPoint.position - player.position).magnitude < 10f) {
			myText.text = "Use WASD to navigate around this ocean. Press SPACE when you've found the treasure!";
			Debug.Log("start");
		} else if ((trees.position - player.position).magnitude < 10f) {
			myText.text = "Go Southwest until you see a big upside-down, U-shaped rock.";
		} 

		else if ((rock.position - player.position).magnitude < 10f) {
			myText.text = "Keep going East until you see an island with 1 palm tree. The treasure is nearby.";
		} 

		// winning 
		else if ((treasure.position - player.position).magnitude < 10f) {
			//Debug.Log ("YOU WIN");
			if (Input.GetKey(KeyCode.Space)) {
				myText.text = "CONGRATULATIONS, YOU WIN!!!";
			}
		}

		else {
			myText.text = "";

		}

	
	}
}
