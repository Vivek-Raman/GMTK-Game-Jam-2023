﻿using DG.Tweening;
using UnityEngine;

namespace GGJ.Poached.Utility
{
    public class CameraShake : MonoBehaviour
    {
        public static CameraShake Instance;

        private void Awake() => Instance = this;

        public static void Shake(float duration, float strength) => Instance.OnShake(duration, strength);

        private void OnShake(float duration, float strength)
        {
            transform.DOShakePosition(duration, strength);
            transform.DOShakeRotation(duration, strength);
        }
    }
}