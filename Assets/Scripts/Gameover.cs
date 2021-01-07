using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    public void LoadGameOver()
	{
		if(PlayerPrefs.GetInt("HighScore",0) < PlayerPrefs.GetInt("Score"))
		{
			Debug.Log("HighScore");
			PlayerPrefs.SetInt("HighScore",PlayerPrefs.GetInt("Score"));
			SceneManager.LoadScene(6);
		}
		else
		{
			SceneManager.LoadScene(5);
		}
	}
}
