using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public Rigidbody rb;
	public Transform player;
	public Vector3 resetSpeed;
	public Swipe swipeControls;
	
	public bool stop = true;
	public bool acceptingInput = true;
	public float forwardForce = 1000f;
	public float sidewaysForce = 1000f;
	public float startSpeed;
	
	private bool up, down, left, right;
	

	void Start()
	{
		up = down = left = right = false;
		startSpeed = PlayerPrefs.GetFloat("Speed");
		forwardForce += PlayerPrefs.GetInt("Score") * 200;
		rb.AddForce(0, 0, startSpeed, ForceMode.VelocityChange);
		rb.drag = 10;
	}
	
    // Update is called once per frame
    void Update()
    {
		if(acceptingInput)
		{
			if(Input.GetKeyDown("w") || swipeControls.SwipeUp)
			{
				up = true;
			}
			
			if(Input.GetKeyDown("s") || swipeControls.SwipeDown)
			{
				down = true;
			}
			
			if(Input.GetKeyDown("d") || swipeControls.SwipeRight)
			{
				right = true;
			}
			
			if(Input.GetKeyDown("a") || swipeControls.SwipeLeft)
			{
				left = true;
			}
		}
    }
	
	void FixedUpdate()
	{
		
		if(acceptingInput)
		{
			rb.AddForce(0, 0, forwardForce * Time.deltaTime);
			if(up)
			{
				rb.AddForce(0, sidewaysForce, 0, ForceMode.Impulse);
				up = false;
			}
			
			if(down)
			{
				rb.AddForce(0, -sidewaysForce, 0, ForceMode.Impulse);
				down = false;
			}
			
			if(right)
			{
				rb.AddForce(sidewaysForce, 0, 0, ForceMode.Impulse);
				right = false;
			}
			
			if(left)
			{
				rb.AddForce(-sidewaysForce, 0, 0, ForceMode.Impulse);
				left = false;
			}
		}
		
		
		if(player.position.y > 5f && stop)
		{
			stop = false;
			rb.velocity = resetSpeed;
			player.position = new Vector3(player.position.x,5f,player.position.z);
		}
		
		if(player.position.y < -5f && stop)
		{
			stop = false;
			rb.velocity = resetSpeed;
			player.position = new Vector3(player.position.x,-5f,player.position.z);
		}
		
		if(player.position.x > 5f && stop)
		{
			stop = false;
			rb.velocity = resetSpeed;
			player.position = new Vector3(5f, player.position.y,player.position.z);
		}
		
		if(player.position.x < -5f && stop)
		{
			stop = false;
			rb.velocity = resetSpeed;
			player.position = new Vector3(-5f, player.position.y,player.position.z);
		}
	}
}
