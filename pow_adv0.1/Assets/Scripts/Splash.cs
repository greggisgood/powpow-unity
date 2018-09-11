using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {

    public float levelDelay; // Number of seconds before switching to the next scene
    public string newLevel; // The String of the new Scene to be loaded

	// Use this for initialization
	void Start () {
        StartCoroutine(LoadLevelAfterDelay());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator LoadLevelAfterDelay()
    {
        yield return new WaitForSeconds(levelDelay);
        SceneManager.LoadScene(newLevel);
    }
}
