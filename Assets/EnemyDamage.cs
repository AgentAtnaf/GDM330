using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damageAmount = 10; // Amount of damage the enemy deals

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Change "Player" to the appropriate tag for the player GameObject
        {
            // Assuming the player has a script for health
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount); // Deal damage to the player
            }
        }
    }
}
