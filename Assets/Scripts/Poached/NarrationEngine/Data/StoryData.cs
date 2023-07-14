using System.Collections.Generic;
using GGJ.Poached.NarrationEngine.Data.StoryStages;
using UnityEngine;

namespace GGJ.Poached.NarrationEngine.Data
{
[CreateAssetMenu]
public class StoryData : ScriptableObject
{
    [SerializeField] private List<CharacterData> associatedCharacters;
    [SerializeField] private List<StoryStageData> storyStages;

    #region Public Getters

    public List<CharacterData> AssociatedCharacters => associatedCharacters;
    public List<StoryStageData> StoryStages => storyStages;

    #endregion
}
}
