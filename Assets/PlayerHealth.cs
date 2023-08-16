using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100; // Maximum health value
    public int currentHealth;   // Current health value

    private void Start()
    {
        currentHealth = maxHealth; // Set initial health to maximum
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; // Reduce current health by the damage amount

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Implement actions to perform when the player's health reaches zero
        // For example, showing a game over screen, respawning, etc.
        Debug.Log("Player has died.");
        // You can add more logic here based on your game's requirements.
    }
}
