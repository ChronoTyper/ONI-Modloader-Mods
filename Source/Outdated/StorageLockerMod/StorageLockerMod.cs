﻿using Harmony;
using JetBrains.Annotations;

namespace Patches
{
    public static class StorageLockerMod
    {
        [HarmonyPatch(typeof(StorageLockerConfig), nameof(StorageLockerConfig.CreateBuildingDef))]
        public static class StorageLockerConfigPatch
        {
            public static void Postfix([NotNull] ref BuildingDef __result)
            {
                __result.BuildLocationRule = BuildLocationRule.Tile;
                __result.ContinuouslyCheckFoundation = false;
                __result.PermittedRotations = PermittedRotations.R360;
            }
        }
    }
}
