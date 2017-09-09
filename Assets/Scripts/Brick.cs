using UnityEngine;

public class Brick : MonoBehaviour {
    
    public int maxHits;
    public Sprite[] hitSprites;

    int timesHit;
    LevelManager levelManager;
	
    // Use this for initialization
	void Start () 
    {
        timesHit = 0;
        levelManager = FindObjectOfType<LevelManager>();
    }
	
	// Update is called once per frame
	void Update () 
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;

        if (timesHit >= maxHits) 
        {
            Destroy(gameObject);
        }
        else {
            LoadSprite();
        }
    }

    void LoadSprite() {
        int spriteIndex = timesHit - 1;

        GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
    }

    // TODO : remove this methods when we can actually win
    void SimulateWin() 
    {
        levelManager.LoadNextLevel();
    }
}
