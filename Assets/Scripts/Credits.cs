using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{

	public Text scoreText;
	public Text highScore;
	public Swipe swipeControls;
	
	private int HighScore;
	
	void Start()
	{
		HighScore = PlayerPrefs.GetInt("HighScore");
		scoreText.text = PlayerPrefs.GetInt("Score").ToString();
		highScore.text = $"High Score: {HighScore}";
	}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
		{
			Quit();
		}
		else if(Input.anyKeyDown || swipeControls.Tap)
		{
			PlayerPrefs.SetInt("Score",0);
			SceneManager.LoadScene(Random.Range(1,5));
		}
    }
	
	public void Quit()
	{
		Debug.Log("Quit");
		Application.Quit();
	}
}
