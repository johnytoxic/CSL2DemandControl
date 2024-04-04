using Colossal.Collections;
using Game.Simulation;
using HarmonyLib;
using Unity.Collections;
using Unity.Mathematics;

namespace InfiniteDemand
{
    [HarmonyPatch(typeof(CommercialDemandSystem), "OnUpdate")]
    public class CommercialDemandSystemPatch
    {
        private static AccessTools.FieldRef<CommercialDemandSystem, NativeValue<int>> BuildingDemandRef =
            AccessTools.FieldRefAccess<CommercialDemandSystem, NativeValue<int>>("m_BuildingDemand");

        static void Prefix(CommercialDemandSystem __instance)
        {
            BuildingDemandRef(__instance).value = 255;
        }
    }

    [HarmonyPatch(typeof(IndustrialDemandSystem), "OnUpdate")]
    public class IndustrialDemandSystemPatch
    {
        private static AccessTools.FieldRef<IndustrialDemandSystem, NativeValue<int>> IndustrialBuildingDemandRef =
            AccessTools.FieldRefAccess<IndustrialDemandSystem, NativeValue<int>>("m_IndustrialBuildingDemand");
        private static AccessTools.FieldRef<IndustrialDemandSystem, NativeValue<int>> StorageBuildingDemand =
            AccessTools.FieldRefAccess<IndustrialDemandSystem, NativeValue<int>>("m_StorageBuildingDemand");
        private static AccessTools.FieldRef<IndustrialDemandSystem, NativeValue<int>> OfficeBuildingDemand =
            AccessTools.FieldRefAccess<IndustrialDemandSystem, NativeValue<int>>("m_OfficeBuildingDemand");

        static void Prefix(IndustrialDemandSystem __instance)
        {
            IndustrialBuildingDemandRef(__instance).value = 255;
            StorageBuildingDemand(__instance).value = 255;
            OfficeBuildingDemand(__instance).value = 255;
        }
    }

    [HarmonyPatch(typeof(ResidentialDemandSystem), "OnUpdate")]
    public class ResidentialDemandSystemPatch
    {
        private static AccessTools.FieldRef<ResidentialDemandSystem, NativeValue<int3>> BuildingDemandRef =
            AccessTools.FieldRefAccess<ResidentialDemandSystem, NativeValue<int3>>("m_BuildingDemand");
        private static AccessTools.FieldRef<ResidentialDemandSystem, NativeValue<int>> HouseholdDemandRef =
            AccessTools.FieldRefAccess<ResidentialDemandSystem, NativeValue<int>>("m_HouseholdDemand");

        private static AccessTools.FieldRef<ResidentialDemandSystem, NativeArray<int>> LowDemandFactorsRef =
            AccessTools.FieldRefAccess<ResidentialDemandSystem, NativeArray<int>>("m_LowDemandFactors");
        private static AccessTools.FieldRef<ResidentialDemandSystem, NativeArray<int>> MediumDemandFactorsRef =
            AccessTools.FieldRefAccess<ResidentialDemandSystem, NativeArray<int>>("m_MediumDemandFactors");
        private static AccessTools.FieldRef<ResidentialDemandSystem, NativeArray<int>> HighDemandFactorsRef =
            AccessTools.FieldRefAccess<ResidentialDemandSystem, NativeArray<int>>("m_HighDemandFactors");

        private static DemandFactor[] Factors =
        {
            DemandFactor.StorageLevels,
            DemandFactor.EducatedWorkforce,
            DemandFactor.CompanyWealth,
            DemandFactor.LocalDemand,
            DemandFactor.FreeWorkplaces,
            DemandFactor.Happiness,
            DemandFactor.TouristDemand,
            DemandFactor.LocalInputs,
            DemandFactor.Taxes,
            DemandFactor.Students,
            DemandFactor.Warehouses,
        };

        static void Prefix(ResidentialDemandSystem __instance)
        {
            BuildingDemandRef(__instance).value = 255;
            HouseholdDemandRef(__instance).value = 255;

            foreach (var factor in Factors)
            {
                LowDemandFactorsRef(__instance)[(int)factor] = 255;
                MediumDemandFactorsRef(__instance)[(int)factor] = 255;
                HighDemandFactorsRef(__instance)[(int)factor] = 255;
            }
        }
    }
}
