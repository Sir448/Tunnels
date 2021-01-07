using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
	public Swipe swipeControls;
	
	void Update()
	{
		if(Input.anyKeyDown || swipeControls.Tap)
		{
			StartGame();
		}
	}
	
	public void StartGame()
	{
		PlayerPrefs.SetInt("Score",0);
		PlayerPrefs.SetFloat("Speed",0);
		PlayerPrefs.SetInt("HighScore",PlayerPrefs.GetInt("HighScore",0));
		SceneManager.LoadScene(Random.Range(1,5));
	}
}
