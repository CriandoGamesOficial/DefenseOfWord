using Assets.Scripts.Enemies;
using UnityEngine;

namespace Assets._Game.Scripts.Enemies.Craft
{
    class DoubleGun : EnemyBase
    {

        [SerializeField]
        private Transform GunLeft;

        [SerializeField]
        private Transform GunRigt;

        [SerializeField]
        private GameObject Bullet;

        [SerializeField]
        private float TweeDownTime;

        protected override void Start()
        {
            base.Start();
        }


        private void FixedUpdate()
        {

            if (TweeDownTime > 0){
                TweeDownTime -= Time.deltaTime;
                base.Tweem();
                ShotSides();
            }
            else{
                //implement
            }
        }

        private void ShotSides()
        {
            base.SetShot(Bullet, GunLeft);
            base.SetShot(Bullet, GunRigt);
        }
    }
}
