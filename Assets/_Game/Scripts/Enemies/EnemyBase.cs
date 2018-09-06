using Assets.Scripts.Common.CommonInterfaces;
using Assets.Scripts.Enemies.EnemyShot;
using UnityEngine;

namespace Assets.Scripts.Enemies
{

    public abstract class EnemyBase: MonoBehaviour
    {
        [SerializeField]
        protected float Speed;

        [SerializeField]
        protected float SpeedShot;

        [SerializeField]
        protected float SpeedTime;

        [SerializeField]
        protected float damage;

        [SerializeField]
        protected float Energy;

        [SerializeField]
        protected float TimeExplosion;

        [SerializeField]
        protected GameObject ExplosionAimation;

        [SerializeField]
        protected GameObject ExplosionPosition;

        [SerializeField]
        protected GameObject[] PowerUp;

        [SerializeField]
        private sbyte tweenX;

        [SerializeField]
        private sbyte tweenY;

        protected Rigidbody2D rigidbody2D;

        protected SpriteRenderer spriteRenderer;

        protected Animator animator;

        protected virtual void Start()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
            spriteRenderer = GetComponent<SpriteRenderer>();
            animator = GetComponent<Animator>();  
        }

        protected virtual void SetPowerUp()
        {
            //Definir tipos de premiação 
        }

        protected virtual void Tweem()
        {
            Vector3 Moviment = new Vector3(tweenX, tweenY);

            rigidbody2D.velocity = Moviment * Speed;
        }

        protected void SetDestroy()
        {
          var obj =  Instantiate(ExplosionAimation);

          obj.transform.position = ExplosionPosition.transform.position;

           //set score of Destroy Enimes

          Destroy(gameObject,TimeExplosion);
        }

        protected virtual void SetShot(GameObject Shot,Transform Position)
        {
           var shot = Instantiate(Shot);

            shot.transform.position = Position.position;

           shot.GetComponent<EnemyShotBase>().SetSpeed(SpeedShot);
        }
       

        protected void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player")|| collision.CompareTag("PlayerShield")){
                collision.GetComponent<IDamage>().Set(damage);
            }

            if (collision.CompareTag("Limit")){
                Destroy(gameObject);
            }
            
        }

        public void SetDamage(float value)
        {
            Energy -= value;

            if (Energy <=0){
                SetDestroy();
            }


        }


    }

}