using UnityEngine;


namespace Assets.Scripts.Enimies
{

    abstract class EnemyBase: MonoBehaviour
    {
        [SerializeField]
        protected float Speed;
        [SerializeField]
        protected float SpeedShot;

    }

}