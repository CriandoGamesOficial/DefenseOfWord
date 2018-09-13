using UnityEngine;
namespace Assets.Scripts.Enemies.EnemyShot
{

    [RequireComponent(typeof(Rigidbody2D))]

    public abstract class EnemyShotBase : MonoBehaviour
    {

        private int X { get; set; }
        private int Y  { get; set; }
        private float Damage { get; set; }

        [HideInInspector]
        protected float Speed { get; set; }

        private Rigidbody2D rigidbody;


        public void Set(float speed, int x,float damage, int y)
        {
            this.X = x;
            this.Y = y;
            this.Speed = Speed;
            this.Damage = damage;
        }


        private void Start()
        {
            rigidbody = GetComponent<Rigidbody2D>();       
        }


        private void FixedUpdate()
        {
            Vector3 mov = new Vector3() { x = X, y = Y, z = 0 };
            rigidbody.velocity = mov * Speed;
        }
    }

}