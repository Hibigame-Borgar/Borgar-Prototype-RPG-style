using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatEntity : MonoBehaviour
{
    // Made everything public because why not
    public int startingHealth;
    public int basicAttack;
    public int basicDefense;

    public int health;
    public int attack;  // To take in account buffs and debuffs,
    public int defense; // will implement later — or maybe not

    public CombatManager manager;

    public void Start()
    {
        attack = basicAttack;
        defense = basicDefense;
        health = startingHealth;
        manager.AddFighter(this);
    }

    public void TakeDamage(int damage)
    {
        // Probably a bad idea performance-wise to reference the entire GameObject
        // Unless it is optimized by the """compiler"""
        Debug.Log(gameObject.name + " has taken " + (damage - defense) + " damage!");
        
        health -= damage - defense;
        if (health <= 0)
        {
            Debug.Log(gameObject.name + " has died!");
            manager.Kill(this);
        }
        else
        {
            Debug.Log(gameObject.name + " now has " + health + " HP!");
        }
    }
}
