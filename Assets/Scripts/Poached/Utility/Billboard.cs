using UnityEngine;

namespace GGJ.Poached.Utility
{
    public class Billboard : MonoBehaviour
    {
        [SerializeField] private bool isEnabled = true;
    
        private Transform cam;

        private void Awake()
        {
            if (Camera.main != null) cam = Camera.main.transform;
        }

        private void LateUpdate()
        {
            if (!isEnabled) return;
            transform.LookAt(cam);
            transform.Rotate(0, 180, 0);
        }
    }
}