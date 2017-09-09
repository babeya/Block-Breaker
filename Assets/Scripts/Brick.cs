using UnityEngine;

public class Brick : MonoBehaviour {
    
    public int maxHits;

    int timesHit;

	// Use this for initialization
	void Start () {
        timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        print(timesHit);

        if (timesHit >= maxHits) {
            Destroy(this);
        }
    }
}
