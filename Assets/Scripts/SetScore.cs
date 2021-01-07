using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour
{
	public Text scoreText;
	
	void Start()
	{
		scoreText.text = PlayerPrefs.GetInt("Score").ToString();
	}
	
}
