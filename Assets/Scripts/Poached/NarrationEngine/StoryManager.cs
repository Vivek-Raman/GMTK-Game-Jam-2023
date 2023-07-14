using System.Collections;
using System.Collections.Generic;
using GGJ.Poached.Gameplay.Character;
using GGJ.Poached.NarrationEngine.Data;
using UnityEngine;

namespace GGJ.Poached.NarrationEngine
{
public class StoryManager : MonoBehaviour
{
    [SerializeField] private List<StoryData> stories;

    private Dictionary<CharacterData, List<StoryState>> _storiesByCharacters = null;

    private void Awake()
    {
        _storiesByCharacters = GenerateStoriesState();
    }

    private void OnDisable()
    {
        GameManager.Characters.onCharacterSpawnedInScene.RemoveListener(OnCharacterEntersScene);
    }

    public void OnCharacterEntersScene(CharacterData characterData, CharacterState instance)
    {
        // TODO: activate associated stories
    }

    private Dictionary<CharacterData, List<StoryState>> GenerateStoriesState()
    {
        Dictionary<CharacterData, List<StoryState>> storiesByCharacters =
            new Dictionary<CharacterData, List<StoryState>>();
        foreach (StoryData story in stories)
        {
            foreach (CharacterData associatedCharacter in story.AssociatedCharacters)
            {

                if (!storiesByCharacters.ContainsKey(associatedCharacter))
                {
                    storiesByCharacters[associatedCharacter] = new List<StoryState>();
                }

                StoryState storyState = new StoryState();
                storyState.StoryData = story;
                storyState.CurrentStageIndex = -1;
                storiesByCharacters[associatedCharacter].Add(storyState);
            }
        }

        return storiesByCharacters;
    }

    public IEnumerator ProgressCharacterStory(CharacterData character)
    {
        foreach (StoryState story in _storiesByCharacters[character])
        {
            if (!story.CanProgressStory()) continue;

            ++story.CurrentStageIndex;
            yield return story.CurrentStage.OnStageProcess();
        }
    }
}
}
