using System.Collections;
using System.Collections.Generic;
using GGJ.Poached.Gameplay.Character;
using Unity.Logging;
using UnityEngine;

namespace GGJ.Poached.NarrationEngine.Data.StoryStages
{
[CreateAssetMenu]
public class DialogueStoryStageData : StoryStageData
{
    [SerializeField] private List<DialogueData> dialogues;

    public override IEnumerator OnStageProcess()
    {
        List<CharacterData> characters = dialogues.ConvertAll(dialogue => dialogue.CharacterData);
        Dictionary<string, CharacterState> characterInstances = GameManager.Characters.LocateCharactersInScene(characters);

        Log.Debug("DialogueStoryStage start");

        foreach (DialogueData dialogue in dialogues)
        {
            Debug_PrintDialogueToLogs(dialogue);

            // TODO: yield control to dialogue system
            // yield return dialogueSystem.showLines(characterInstances[dialogue.CharacterData.CharacterName], dialogue.Lines);
        }

        Log.Debug("DialogueStoryStage end");
        yield break;
    }

    private void Debug_PrintDialogueToLogs(DialogueData dialogue)
    {
        foreach (string line in dialogue.Lines)
        {
            Log.Debug("DialogueStoryStage {CharacterName} : {line}", dialogue.CharacterData.CharacterName, line);
        }

    }
}
}
