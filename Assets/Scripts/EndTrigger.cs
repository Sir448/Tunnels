using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
	public Rigidbody rb;
	
	public bool gameover = false;
	
	void OnTriggerEnter()
	{
		if(!gameover)
		{	
			PlayerPrefs.SetFloat("Speed",rb.velocity.magnitude);
			gameManager.CompleteLevel();
		}
	}
}
