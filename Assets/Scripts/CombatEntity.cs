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
    public int defense; // will implement later

    public CombatManager manager;

    public void Start()
    {
        attack = basicAttack;
        defense = basicDefense;
        health = startingHealth;
    }

    public void takeDamage(int damage)
    {
        health -= damage - defense;
        if (health <= 0)
        {
            manager.kill(this);
        }
    }
}
