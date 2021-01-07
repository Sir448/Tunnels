using UnityEngine;

public class GameoverFade : MonoBehaviour
{
	public GameObject gameoverUI;
	
    public void fade()
	{
		gameoverUI.SetActive(false);
	}
}
