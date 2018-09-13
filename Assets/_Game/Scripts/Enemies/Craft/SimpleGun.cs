using Assets.Scripts.Enemies;
using UnityEngine;

namespace Assets._Game.Scripts.Enemies.Craft
{
    class SimpleGun : EnemyBase
    {

        [SerializeField]
        private Transform Gun;

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
                Shot();
            }
            else{
                //implement
            }
        } 

        private void Shot()
        {
            base.SetShot(Bullet, Gun);

        }
    }
}
