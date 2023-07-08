using Unity.Logging;
using UnityEngine;

namespace GGJ.Poached.UI
{
public class MainMenu : MonoBehaviour
{
    public void UI_ExitGame()
    {
        Log.Warning("Closing application");
        Application.Quit();
    }
}
}
