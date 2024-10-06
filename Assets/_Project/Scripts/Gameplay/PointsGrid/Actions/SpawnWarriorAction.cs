﻿using Gameplay.Map;
using Gameplay.Map.Allies;
using Gameplay.Map.Spawn;
using Runtime.Utils;
using UnityEngine;
using UnityEngine.Localization;

namespace Audio.Gameplay.PointsGrid
{
    [System.Serializable]
    public class SpawnWarriorAction : IGridPointAction
    {
        [SerializeField] private LocalizedString _description;
        [SerializeField] private EWarriorClass _class;
        public ReactiveLocalizedString GetDescription() => new (_description);
        
        public void ApplyAction(
            SpawnModifiers momentModifiers,
            SpawnModifiers constantModifiers,
            WarriorsCollection warriors)
        {
            if (_class == EWarriorClass.Mage)
                momentModifiers.MagesCount++;
            else if (_class == EWarriorClass.Soldier)
                momentModifiers.SoldiersCount++;
            else if (_class == EWarriorClass.Tank)
                momentModifiers.TanksCount++;
        }
    }
}