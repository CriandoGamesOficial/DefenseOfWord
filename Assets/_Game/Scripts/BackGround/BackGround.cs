using UnityEngine;

namespace Assets._Game.Scripts.BackGround
{
    class BackGround : MonoBehaviour
    {
        [Header("Conf BackGround")]
        [SerializeField]
        private Vector2 speed;

        private new Renderer renderer;

        private void Start()
        {
            renderer = GetComponent<Renderer>();
        }


        private void LateUpdate()
        {
            renderer.material.mainTextureOffset = speed * Time.time;
        }
    }
}
