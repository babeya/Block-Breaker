using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    static float minX = 0.5f;
    static float maxX = 15.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;

        Vector3 paddlePos = new Vector3(
            Mathf.Clamp(mousePosInBlocks, minX, maxX), 
            transform.position.y
        );

        transform.position = paddlePos;
	}
}
