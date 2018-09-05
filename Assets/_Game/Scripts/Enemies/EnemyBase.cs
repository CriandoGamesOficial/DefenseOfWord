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
        protected float Speeds;

        [SerializeField]
        protected float Idamage;

        [SerializeField]
        protected GameObject ExplosionAimation;

        [SerializeField]
        protected GameObject ExplosionPosition;

        [SerializeField]
        protected GameObject[] PowerUp;

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

        protected virtual void Tweem(float x, float y)
        {
            Vector3 Moviment = new Vector3(x, y);

            rigidbody2D.velocity = Moviment * Speed;
        }

        protected virtual void SetDestroy(float time)
        {
          var obj =  Instantiate(ExplosionAimation);

          obj.transform.position = ExplosionPosition.transform.position;

           //set score of Destroy Enimes

          Destroy(gameObject,time);
        }

        protected virtual void SetShot(GameObject Shot,Transform Position)
        {
           var shot = Instantiate(Shot);

            shot.transform.position = Position.position;

           shot.GetComponent<EnemyShotBase>().SetSpeed(Speeds);
        }
       
        public abstract void SetShot();

        protected void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player")|| collision.CompareTag("PlayerShield")){
                collision.GetComponent<IDamage>().Set(Idamage);
            }

            if (collision.CompareTag("Limit")){
                Destroy(gameObject);
            }
            
        }


    }

}