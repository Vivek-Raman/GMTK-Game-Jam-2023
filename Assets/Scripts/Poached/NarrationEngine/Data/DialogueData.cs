using System;
using System.Collections.Generic;
using UnityEngine;

namespace GGJ.Poached.NarrationEngine.Data
{
[Serializable]
public class DialogueData
{
    [SerializeField] private CharacterData characterData;
    [SerializeField] private List<string> lines;

    #region Public Getters

    public CharacterData CharacterData => characterData;
    public List<string> Lines => lines;

    #endregion
}
}
