using System.Collections;
using UnityEngine;

namespace GGJ.Poached.NarrationEngine.Data.StoryStages
{
public abstract class StoryStageData : ScriptableObject
{
    // TODO: call this method
    public virtual bool CanProgressStage()
    {
        return true;
    }

    // TODO: call this method
    public abstract IEnumerator OnStageProcess();
}
}
