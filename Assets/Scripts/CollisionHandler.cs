using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] private GameObject destroyedVfx;
    [SerializeField] GameSceneManager gameSceneManager;

    private void Start()
    {
        gameSceneManager = FindFirstObjectByType<GameSceneManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Collided();
    }

    private void Collided()
    {
        Instantiate(destroyedVfx, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
        gameSceneManager.ReloadLevel();
        
    }

    private void OnParticleCollision(GameObject other)
    {
        Collided();
        Debug.Log("Particle Collision");
    }
}
