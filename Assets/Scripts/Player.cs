using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CombatManager manager;
    public CombatEntity entity;

    void Start()
    {
        entity = GetComponent<CombatEntity>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Player attacked!");
            manager.Attack(entity);
        }
    }
}
