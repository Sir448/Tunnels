using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	
	public GameObject gameoverUI;
	
	public void CompleteLevel()
	{
		PlayerPrefs.SetInt("Score",PlayerPrefs.GetInt("Score")+1);
		SceneManager.LoadScene(Random.Range(1,5));
	}
	
	public void EndGame()
	{
		gameoverUI.SetActive(true);
	}
	
}
