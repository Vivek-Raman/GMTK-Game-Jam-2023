using System;
using GGJ.Poached.NarrationEngine.Data;
using GGJ.Poached.NarrationEngine.Data.StoryStages;

namespace GGJ.Poached.NarrationEngine
{
[Serializable]
public class StoryState
{
    public StoryData StoryData { get; set; }
    public int CurrentStageIndex { get; set; }

    public StoryStageData CurrentStage => this.StoryData.StoryStages[this.CurrentStageIndex];
    private StoryStageData NextStage => this.StoryData.StoryStages[this.CurrentStageIndex + 1];

    public bool CanProgressStory()
    {
        return CurrentStageIndex < StoryData.StoryStages.Count && NextStage.CanProgressStage();
    }
}
}
