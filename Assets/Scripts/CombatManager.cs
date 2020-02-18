using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// There surely is a faster simpler and cleaner way to do this but heh
// It's just a prototype let's get things functionning quick

public class CombatManager : MonoBehaviour
{
    public List<CombatEntity> fighters;
    
    public void AddFighter(CombatEntity fighter)
    {
        fighters.Add(fighter);
    }

    public void Kill(CombatEntity entity)
    {
        fighters.Remove(entity); // does this work?
    }

    public void Attack(CombatEntity attacker)
    {
        // THIS IS TEMPORARY, FOR TESTING PURPOSES
        CombatEntity attacked = attacker == fighters[0] ? fighters[1] : fighters[0];
        attacked.TakeDamage(attacker.attack);
    }
}
































// I like comments

/*
 * these
 * ones
 * are
 * nice
 * as
 * well
 */
