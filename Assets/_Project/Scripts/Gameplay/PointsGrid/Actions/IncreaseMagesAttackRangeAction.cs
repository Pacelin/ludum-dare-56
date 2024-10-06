﻿using Gameplay.Map.Allies;
using Gameplay.Map.Spawn;
using Runtime.Utils;
using UnityEngine;
using UnityEngine.Localization;

namespace Audio.Gameplay.PointsGrid
{
    [System.Serializable]
    public class IncreaseMagesAttackRangeAction : IGridPointAction
    {
        [SerializeField] private LocalizedString _description;
        [SerializeField] private float _increaseConstantAttackRange = 0.1f;
        [SerializeField] private float _increaseMomentAttackRange = 1f;
        
        public ReactiveLocalizedString GetDescription() => new (_description);
        
        public void ApplyAction(
            SpawnModifiers momentModifiers,
            SpawnModifiers constantModifiers,
            WarriorsCollection warriors)
        {
            momentModifiers.MagesAttackRange += _increaseMomentAttackRange;
            constantModifiers.MagesAttackRange += _increaseConstantAttackRange;
        }
    }
}