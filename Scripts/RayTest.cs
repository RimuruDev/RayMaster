using UnityEngine;

namespace RimuruDev.RayMaster
{
    public class RayTest : MonoBehaviour
    {
        public Camera CameraCamera;

        private void Start() => Ray.RayCamera = CameraCamera;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Get();
            }

            if (Input.GetMouseButtonDown(1))
            {
                TryGet();
            }
        }

        public void Get()
        {
            var trueComponent = Ray.Get<IColor>();

            if (trueComponent != null)
            {
                trueComponent.GetComponent<IColor>().Swith();
            }
            else
                Debug.Log("Miss");
        }

        public void TryGet()
        {
            if (Ray.TryGet<IColor>(out var component))
            {
                component.Swith();
            }
            else
                Debug.Log("Miss");
        }
    }
}