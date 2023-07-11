using UnityEngine;

namespace GGJ.Poached.NarrationEngine.Data
{
[CreateAssetMenu]
public class CharacterData : ScriptableObject
{
    [SerializeField] private string characterName;
    [SerializeField] private GameObject prefab;

    #region Public Getters

    public string CharacterName => characterName;

    [Tooltip("Ensure that the root GameObject of the prefab has a Character component!")]
    public GameObject Prefab => prefab;

    #endregion
}
}
