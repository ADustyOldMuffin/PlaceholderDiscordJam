﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

namespace Enemies
{
    public class EnemyMeleeAttack : MonoBehaviour
    {
        private Collider2D myCol;
        [SerializeField] int attackPower = 1;
        private EnemyMovement movement;

        void Awake()
        {
            myCol = GetComponent<Collider2D>();
            movement = GetComponent<EnemyMovement>();
        }

        
    }
}
