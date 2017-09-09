using UnityEngine;

public class Ball : MonoBehaviour 
{
    public Paddle paddle;

    Vector3 paddleToBallVector;
    bool hasStarted = false;

	// Use this for initialization
	void Start () 
    {
        paddleToBallVector = transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(!hasStarted) 
        {
            transform.position = paddle.transform.position + paddleToBallVector;    
        }

        if (Input.GetMouseButtonDown(0)) 
        {
            hasStarted = !hasStarted;
            Rigidbody2D body = GetComponent<Rigidbody2D>();

            body.velocity = new Vector2(1f, 10f);
        }
	}
}
