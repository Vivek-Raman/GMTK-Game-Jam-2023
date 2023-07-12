using System;
using System.Collections;
using System.Collections.Generic;
using GGJ.Poached.Gameplay.Character;
using GGJ.Poached.NarrationEngine.Data;
using TMPro;
using Unity.Logging;
using UnityEngine;

namespace GGJ.Poached.UI.Dialogue
{
public class DialogueDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text type;
    
    private void Awake()
    {
        // throw new NotImplementedException();
    }

    public IEnumerator showLines(CharacterData characterData, List<string> dialogueLines)
    {
        foreach (string line in dialogueLines)
        {
            Log.Debug("DialogueStoryStage {CharacterName} : {line}", characterData.CharacterName, line);
            yield return WaitForPlayerConfirmation(KeyCode.Space);
        }

        yield break;
    }

    private IEnumerator WaitForPlayerConfirmation(KeyCode key)
    {
        yield return new WaitUntil(() => Input.GetKeyUp(key));
    }
}
}
