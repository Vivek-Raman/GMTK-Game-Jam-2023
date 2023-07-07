using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Dummy class to showcase how to use audio engine
/// </summary>
public class PlaySfx : MonoBehaviour
{
    [SerializeField] private AudioClip clip;
    
    private void MyFunc()
    {
        SoundManager.Instance.PlaySound(clip);
    }
}
