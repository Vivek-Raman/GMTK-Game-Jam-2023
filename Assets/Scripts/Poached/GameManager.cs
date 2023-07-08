using GGJ.Poached.Audio;
using GGJ.Poached.UI;
using GGJ.Poached.Utility;
using UnityEngine;

namespace GGJ.Poached
{
[RequireComponent(typeof(PauseManager))]
[RequireComponent(typeof(AudioManager))]
public class GameManager : SingletonMonoBehaviour<GameManager>
{
    // private SettingsManager _settingsManager;
    private AudioManager _audioManager;
    // private CameraManager _cameraManager;
    private PauseManager _pauseManager;
    // private PlayerManager _playerManager;

    #region Public Getters

    // public static SettingsManager Settings => Instance._settingsManager;
    public static AudioManager Audio => Instance._audioManager;
    // public static CameraManager Camera => Instance._cameraManager;
    public static PauseManager Pause => Instance._pauseManager;
    // public static PlayerManager Player => Instance._playerManager;

    #endregion

    protected override void Awake()
    {
        base.Awake();

        // InitializeSettings();
        // InitializeAudio();
        // InitializeCamera();
        InitializePause();
        // InitializePlayer();
    }

    #region Initialize Methods

    private void InitializePause()
    {
        _pauseManager = this.GetComponent<PauseManager>();
        _pauseManager.UnpauseGame();
    }

    #endregion Initialize Methods
}
}
