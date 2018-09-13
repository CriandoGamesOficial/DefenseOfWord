using System;
using Assets.Scripts.Enemies;
using UnityEngine;

namespace Assets._Game.Scripts.Enemies.Craft
{
    class TripleGun : EnemyBase
    {


        [SerializeField]
        private Transform GunLeft;

        [SerializeField]
        private Transform GunRigt;

        [SerializeField]
        private Transform GunCenter;

        [SerializeField]
        private GameObject BulletCenter;

        [SerializeField]
        private GameObject BulleSides;

        [SerializeField]
        private float TweeDownTime;

        protected override void Start()
        {
            base.Start();
        }


        private void FixedUpdate()
        {

            if (TweeDownTime >0)
            {
                TweeDownTime -= Time.deltaTime;
                base.Tweem();
                ShotSides();
            }
            else
            {
                ShotCenter();

            }
        }

        private void ShotCenter()
        {
            base.SetShot(BulletCenter, GunCenter);
        }

        private void ShotSides()
        {
            base.SetShot(BulleSides, GunLeft);
            base.SetShot(BulleSides, GunRigt);
        }

        private void SetLeft()
        {
        }

        private void SetRight()
        {
        }


    }
}
