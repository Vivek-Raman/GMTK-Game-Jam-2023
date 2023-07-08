﻿using System;
using System.Collections;
using UnityEngine;

namespace GGJ.Poached.Utility
{
    [Serializable]
    public class CD
    {
        public bool State;
        public float Time;

        public IEnumerator Cooldown(bool finalState, Action endAction = null)
        {
            State = !finalState;
            yield return new WaitForSeconds(Time);
            State = finalState;
            endAction?.Invoke();
        }
    }
}