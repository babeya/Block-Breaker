using UnityEngine;

public class Brick : MonoBehaviour
{

    public Sprite[] hitSprites;

    int timesHit;

    LevelManager levelManager;

    // Use this for initialization
    void Start()
    {
        timesHit = 0;
        levelManager = FindObjectOfType<LevelManager>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        bool isBreakable = tag == "Breakable";

        if (isBreakable) {
            HandleHits();
        }
    }

    void HandleHits() 
    {
		int maxHits = hitSprites.Length + 1;

		timesHit++;
		if (timesHit >= maxHits)
		{
			Destroy(gameObject);
		}
		else
		{
			LoadSprite();
		}
    }

    void LoadSprite()
    {
        int spriteIndex = timesHit - 1;

        if (hitSprites[spriteIndex])
        {
            GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }

    }

    // TODO : remove this methods when we can actually win
    void SimulateWin()
    {
        levelManager.LoadNextLevel();
    }
}
