using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool autoPlay = false;

    static float minX = 0.5f;
    static float maxX = 15.5f;
    Ball ball;
    // Use this for initialization
    void Start()
    {
        ball = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!autoPlay)
        {
            MoveWithMouse();
        }
        else {
            AutoPlay();
        }
    }

    void MoveWithMouse()
    {
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;

        Vector3 paddlePos = new Vector3(
            Mathf.Clamp(mousePosInBlocks, minX, maxX),
            transform.position.y
        );

        transform.position = paddlePos;
    }

    void AutoPlay() {
        Vector3 ballPosition = ball.transform.position;

        Vector3 paddlePos = new Vector3(
			Mathf.Clamp(ballPosition.x, minX, maxX),
			transform.position.y
		);

		transform.position = paddlePos;
    }
}
