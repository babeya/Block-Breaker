using UnityEngine;

public class Ball : MonoBehaviour
{
    Paddle paddle;
    Vector3 paddleToBallVector;

    bool hasStarted = false;

    // Use this for initialization
    void Start()
    {
        paddle = FindObjectOfType<Paddle>();
        paddleToBallVector = transform.position - paddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
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

    void OnCollisionEnter2D(Collision2D collision)
    {


        if (hasStarted)
        {
            GetComponent<AudioSource>().Play();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        Vector2 tweak = new Vector2(Random.Range(-0.4f, 0.4F), Random.Range(0.4f, 0.4F));

        if (hasStarted)
        {
            GetComponent<Rigidbody2D>().velocity += tweak;
        }
    }
}
