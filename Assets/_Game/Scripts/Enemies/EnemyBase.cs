using UnityEngine;

namespace Assets.Scripts.Enemies
{

    abstract class EnemyBase: MonoBehaviour
    {
        [SerializeField]
        protected float Speed;

        [SerializeField]
        protected float SpeedShot;

        [SerializeField]
        protected float Speeds;

        [SerializeField]
        protected GameObject ExplosionAimation;

        [SerializeField]
        protected GameObject ExplosionPosition;

        protected virtual void SetDestroy(float time)
        {
          var obj =  Instantiate(ExplosionAimation);
          obj.transform.SetParent(ExplosionPosition.transform);
          Destroy(gameObject,time);
        }
       
       public abstract void SetShot();


    }

}