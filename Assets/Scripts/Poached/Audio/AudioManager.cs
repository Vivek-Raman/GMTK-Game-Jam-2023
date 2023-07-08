using GGJ.Poached.Utility;
using UnityEngine;

namespace GGJ.Poached.Audio
{
    public class AudioManager : MonoBehaviour
    {
        [SerializeField] private AudioSource musicSource;
        [SerializeField] private AudioSource sfxSource;
    
        public void PlaySound(AudioClip clip)
        {
            sfxSource.PlayOneShot(clip);
        }
    }
}
