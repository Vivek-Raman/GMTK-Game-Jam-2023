using System;
using System.Collections.Generic;
using GGJ.Poached.Gameplay.Character;
using GGJ.Poached.NarrationEngine.Data;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

namespace GGJ.Poached.Gameplay
{
public class CharacterManager: MonoBehaviour
{
    [SerializeField] private List<CharacterData> characters;
    [HideInInspector] public UnityEvent<CharacterData, CharacterState> onCharacterSpawnedInScene = new ();
    [HideInInspector] public UnityEvent<CharacterData, CharacterState> onCharacterLeavesScene = new ();

    private Dictionary<string, CharacterState> _charactersInScene = null;

    private void Awake()
    {
        _charactersInScene = new Dictionary<string, CharacterState>();
    }

    [ContextMenu(nameof(SpawnRandomCharacter))]
    public void SpawnRandomCharacter()
    {
        CharacterData toSpawn = characters[Random.Range(0, characters.Count)];
        CharacterState characterState = Instantiate(toSpawn.Prefab).GetComponent<CharacterState>();
        _charactersInScene.Add(toSpawn.CharacterName, characterState);
        onCharacterSpawnedInScene?.Invoke(toSpawn, characterState);
    }

    public Dictionary<string, CharacterState> LocateCharactersInScene(List<CharacterData> characterData)
    {
        Dictionary<string, CharacterState> characterInstances = new Dictionary<string, CharacterState>();
        foreach (CharacterData character in characterData)
        {
            if (_charactersInScene.TryGetValue(character.CharacterName, out CharacterState characterInstance))
            {
                characterInstances.Add(character.CharacterName, characterInstance);
            }
        }

        return characterInstances;
    }
}
}
