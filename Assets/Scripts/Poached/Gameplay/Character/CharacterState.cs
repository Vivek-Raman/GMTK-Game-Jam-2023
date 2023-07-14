using System;
using GGJ.Poached.NarrationEngine.Data;
using Poached.Gameplay.Character;
using UnityEngine;

namespace GGJ.Poached.Gameplay.Character
{
public class CharacterState : MonoBehaviour, IClickable
{
    [SerializeField] private CharacterData characterData;

    // TODO: add runtime character state here

    public void OnClicked()
    {
        StartCoroutine(GameManager.Story.ProgressCharacterStory(characterData));
    }
}
}
