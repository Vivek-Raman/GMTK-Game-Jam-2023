using GGJ.Poached.Audio;
using GGJ.Poached.Gameplay;
using GGJ.Poached.NarrationEngine;
using GGJ.Poached.UI;
using GGJ.Poached.Utility;
using UnityEngine;

namespace GGJ.Poached
{
[RequireComponent(typeof(PauseManager))]
[RequireComponent(typeof(AudioManager))]
[RequireComponent(typeof(CharacterManager))]
[RequireComponent(typeof(StoryManager))]
public class GameManager : SingletonMonoBehaviour<GameManager>
{
    // private SettingsManager _settingsManager;
    private AudioManager _audioManager;
    // private CameraManager _cameraManager;
    private PauseManager _pauseManager;
    private CharacterManager _characterManager;
    private StoryManager _storyManager;

    #region Public Getters

    // public static SettingsManager Settings => Instance._settingsManager;
    public static AudioManager Audio => Instance._audioManager;
    // public static CameraManager Camera => Instance._cameraManager;
    public static PauseManager Pause => Instance._pauseManager;
    public static CharacterManager Characters => Instance._characterManager;
    public static StoryManager Story => Instance._storyManager;

    #endregion

    protected override void Awake()
    {
        base.Awake();

        // InitializeSettings();
        InitializeAudio();
        // InitializeCamera();
        InitializePause();
        InitializeCharacters();
        InitializeStory();
    }

    #region Initialize Methods

    private void InitializePause()
    {
        _pauseManager = this.GetComponent<PauseManager>();
        _pauseManager.UnpauseGame();
    }

    private void InitializeAudio()
    {
        _audioManager = this.GetComponent<AudioManager>();
    }

    private void InitializeCharacters()
    {
        _characterManager = this.GetComponent<CharacterManager>();
    }

    private void InitializeStory()
    {
        _storyManager = this.GetComponent<StoryManager>();
        GameManager.Characters.onCharacterSpawnedInScene.AddListener(_storyManager.OnCharacterEntersScene);
    }

    #endregion Initialize Methods
}
}
