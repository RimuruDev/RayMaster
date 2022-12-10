using System;
using UnityEngine;

namespace RimuruDev.RayMaster
{
    public static class Ray
    {
        #region Fields
        public static Camera RayCamera
        {
            get => rayCamera;
            set
            {
                // previouseName = value.name;
                rayCamera = value;
                // RayMasterInfo.CameraChecker(value);
            }
        }
        private static Camera rayCamera;

        // private static string previouseName;

        private static Vector3 center;
        private static RaycastHit hit;
        #endregion

        #region Constructors
        static Ray()
        {
            if (rayCamera == null)
                rayCamera = Camera.main;

            center = Vector3.one / 2;
            if (rayCamera == null)
                rayCamera = GameObject.FindObjectOfType<Camera>();
        }
        #endregion

        #region Get
        public static UnityEngine.Ray GetCameraCenter()
        {
            return rayCamera.ViewportPointToRay(center);
        }

        public static RaycastHit GetRey()
        {
            Physics.Raycast(GetCameraCenter(), out hit);

            return hit;
        }

        public static bool TryGet<Type>(out Type value) where Type : MonoBehaviour
        {
            if (GetRey().transform.TryGetComponent(out Type outValue))
            {
                value = outValue;
                return true;
            }
            else
            {
                value = default;
                return false;
            }
        }

        public static Component Get<Type>() where Type : MonoBehaviour
        {
            return GetRey().transform.GetComponent<Type>();
        }

        public static bool Get<Type>(out Type component) where Type : MonoBehaviour
        {
            if (TryGet<Type>(out var type))
            {
                component = type;
                return true;
            }
            else
            {
                component = default;
                return false;
            }
        }
        #endregion

        #region GetRey [Overrire classics Physics.Raycast()]
        public static RaycastHit GetRey(float maxDistance)
        {
            Physics.Raycast(GetCameraCenter(), out hit, maxDistance);

            return hit;
        }

        public static RaycastHit GetRey(LayerMask layerMask)
        {
            Physics.Raycast(GetCameraCenter(), out hit, layerMask);

            return hit;
        }

        public static RaycastHit GetRey(float maxDistance, LayerMask layerMask)
        {
            Physics.Raycast(GetCameraCenter(), out hit, maxDistance, layerMask);

            return hit;
        }

        public static RaycastHit GetRey(float maxDistance, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction)
        {
            Physics.Raycast(GetCameraCenter(), out hit, maxDistance, layerMask, queryTriggerInteraction);

            return hit;
        }
        #endregion

        public static class RayMasterInfo
        {
            public static string CameraName
            {
                get
                {
                    if (rayCamera == null)
                        Exeption();

                    return rayCamera.name;
                }
            }

            //public static Action CameraChecker(Camera camera)
            //{
            //    if (rayCamera == null) return default;

            //    string cameraName = previouseName;

            //    void NewCamera()
            //    {
            //        if (cameraName != camera.name)
            //        {
            //            rayCamera = camera;
            //        }
            //    }

            //    return NewCamera;
            //}

            public static GameObject CameraGameObject
            {
                get
                {
                    if (rayCamera == null || rayCamera.gameObject == null)
                        Exeption();

                    return rayCamera.gameObject;
                }
            }

            public static bool IsCameraInit => rayCamera != null;

            internal static void Exeption(string message = null)
            {
                if (message == null)
                    throw new NullReferenceException();
                else
                    throw new NullReferenceException(message);
            }
        }
    }
}