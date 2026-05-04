using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject destroyedVfx;
    [SerializeField] int hitPoints = 3;
    [SerializeField] int scoreValue = 10;

    ScoreBoard scoreBoard;

    private void Start()
    {
        scoreBoard = FindFirstObjectByType<ScoreBoard>();
        if (scoreBoard == null)
        {
            Debug.LogError("No ScoreBoard found in the scene.");
        }
    }
    private void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    private void ProcessHit()
    {
        hitPoints--;

        if (hitPoints <= 0)
        {
            if (scoreBoard != null)
            {
                scoreBoard.IncreaseScore(scoreValue);
            }
            Instantiate(destroyedVfx, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
