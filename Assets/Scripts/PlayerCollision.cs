using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public Rigidbody rb;
	public PlayerMovement movement;
	
	public float ricochet;
	public bool hitWall = false;
	
	void Start()
	{
		ricochet = 0.1f * (1000f * Time.deltaTime + PlayerPrefs.GetInt("Score") * 200);
	}
	
	void OnCollisionEnter (Collision collisionInfo)
	{
		
		
		if(collisionInfo.collider.tag == "Wall" && !hitWall)
		{
			rb.AddForce(0, 0, ricochet);
			hitWall = true;
			rb.drag = 0.25f;
			movement.enabled = false;
			FindObjectOfType<EndTrigger>().gameover = true;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
