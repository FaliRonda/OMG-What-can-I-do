using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButtonController : MonoBehaviour {
	public void loadGame() {
		GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<AudioController> ().button ();
		SceneManager.LoadScene ("_Scene/Intro");
	}
}
