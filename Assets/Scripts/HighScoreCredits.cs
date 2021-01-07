using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HighScoreCredits : MonoBehaviour
{

	public Text scoreText;
	public Swipe swipeControls;
	
	void Start()
	{
		scoreText.text = PlayerPrefs.GetInt("Score").ToString();
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
