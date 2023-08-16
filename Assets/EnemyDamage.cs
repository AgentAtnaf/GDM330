using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damageAmount = 10; // Amount of damage the enemy deals
    public float destroyDelay = 1f; // Delay before the enemy self-destructs

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Change "Player" to the appropriate tag for the player GameObject
        {
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount); // Deal damage to the player
                Destroy(gameObject); // Destroy the enemy
            }
        }
    }

    private void Start()
    {
        Destroy(gameObject, destroyDelay); // Destroy the enemy after the specified delay
    }
}
