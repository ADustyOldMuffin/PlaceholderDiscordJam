﻿using System.Collections;
using Pathfinding;
using Entities;
using UnityEngine;
using Managers;

namespace States
{
    public class FireRangedAttack : IState
    {
        private readonly Enemy _enemy;
        private readonly Animator _enemyAnimator;
        private readonly EnemyProjectile _projectile;
        private readonly float _minTimeBetweenShots;
        private readonly float _maxTimeBetweenShots;

        float shotCounter;

        public FireRangedAttack(Enemy enemy, EnemyProjectile projectile, float minTimeBetweenShots, float maxTimeBetweenShots, Animator enemyAnimator)
        {
            _enemy = enemy;
            _projectile = projectile;
            _minTimeBetweenShots = minTimeBetweenShots;
            _maxTimeBetweenShots = maxTimeBetweenShots;
            shotCounter = Random.Range(minTimeBetweenShots, maxTimeBetweenShots);
            _enemyAnimator = enemyAnimator;
        }

        public void Tick()
        {
            CountDownAndShoot();
        }

        private void CountDownAndShoot()
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0f)
            {
                Fire();
            }
        }

        public void Fire()
        {
            GameObject.Instantiate(_projectile, _enemy.transform.position, Quaternion.identity);
            shotCounter = Random.Range(_minTimeBetweenShots, _maxTimeBetweenShots);
        }

        public void OnEnter()
        {
            //set animator to attack
            //Debug.Log("I am attacking now");
            _enemyAnimator.SetBool("isAttacking", true);
        }

        public void OnExit()
        {
            //Debug.Log("I am no longer attacking");
            //set animator to not attack
            _enemyAnimator.SetBool("isAttacking", false);
        }
    }
}
