using UnityEngine;

public class Brick : MonoBehaviour {
    
    public int maxHits;

    int timesHit;
    LevelManager levelManager;
	
    // Use this for initialization
	void Start () {
        timesHit = 0;
        levelManager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        SimulateWin();
    }

    // TODO : remove this methods when we can actually win
    void SimulateWin() {
        levelManager.LoadNextLevel();
    }
}
