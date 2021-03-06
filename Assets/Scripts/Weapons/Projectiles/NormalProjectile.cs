﻿using System;
using System.Linq;
using Managers;
using UnityEngine;

namespace Weapons.Projectiles
{
    public class NormalProjectile : BaseProjectile
    {
        protected override bool HurtsPlayer { get; } = false;
        protected override int DamageAmount { get; } = 3;
        protected override float ProjectileLifetime { get; } = 10f;

        [SerializeField] private float moveSpeed = 10f;
        [SerializeField] private Rigidbody2D myRigidbody;

        private float _aliveFor = 0.0f;

        private void FixedUpdate()
        {
            var myTransform = transform;
            var newPosition = myTransform.position + _moveDirection * (moveSpeed * Time.fixedDeltaTime);
            myRigidbody.MovePosition(newPosition);
            
            if(_aliveFor >= ProjectileLifetime)
                Destroy(gameObject);

            _aliveFor += Time.fixedDeltaTime;
        }
    }
}