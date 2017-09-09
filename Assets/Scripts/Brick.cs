using UnityEngine;

public class Brick : MonoBehaviour
{
    public static int breakableCount;
    public Sprite[] hitSprites;

    bool isBreakable;
    int timesHit;
    LevelManager levelManager;


    // Use this for initialization
    void Start()
    {
        isBreakable = tag == "Breakable";
        // Keep tracks of breakable bricks
        if (isBreakable)
        {
            breakableCount++;
            print(breakableCount);
        }

        timesHit = 0;
        levelManager = FindObjectOfType<LevelManager>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (isBreakable)
        {
            HandleHits();
        }
    }

	void OnDestroy()
	{
		breakableCount--;
        print(breakableCount);
	}

    void HandleHits()
    {
        int maxHits = hitSprites.Length + 1;

        timesHit++;
        if (timesHit >= maxHits)
        {
            Destroy(gameObject);
            levelManager.BrickDestroyed();
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
}
