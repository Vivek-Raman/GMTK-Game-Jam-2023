using UnityEngine;

namespace GGJ.Poached.Audio
{
    /// <summary>
    /// Dummy class to showcase how to use audio engine
    /// </summary>
    public class PlaySfx : MonoBehaviour
    {
        [SerializeField] private AudioClip clip;
    
        private void MyFunc()
        {
            GameManager.Audio.PlaySound(clip);
        }
    }
}
