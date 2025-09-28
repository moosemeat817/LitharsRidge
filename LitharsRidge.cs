using MelonLoader.Utils;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace LitharsRidge
{
    public class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            Settings.OnLoad();
        }

        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            if (string.IsNullOrEmpty(sceneName))
                return;

            if (sceneName == "CanneryRegion" && Settings.options.litharEnabled && Settings.options.litharHatch)
            {
                RelocatePrepperCache();
                GameObject.Find("Art/Roads/STR_BridgeTrussCDamaged_Prefab").gameObject.SetActive(false);
            }

            if (sceneName == "CanneryRegion_SANDBOX" && Settings.options.litharEnabled)
            {
                EnableSandboxResources();
            }

            if (sceneName == "CanneryRegion_SANDBOX_WILDLIFE" && Settings.options.litharEnabled)
            {
                EnableWildlifeSpawns();
            }
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (string.IsNullOrEmpty(sceneName) || !Settings.options.litharEnabled)
                return;

            if (sceneName == "CanneryRegion")
            {
                InitializeCanneryRegion();
            }
            else if (sceneName == "CanneryRegion_SANDBOX")
            {
                SetupSandboxPositions();
                // Furniture cloning needs to happen for sandbox scene as well
                Clones.ChangeObjects();
            }
            else if (sceneName == "CanneryRegion_SANDBOX_WILDLIFE")
            {
                SetupWildlifePositions();
            }
        }

        private void RelocatePrepperCache()
        {
            var hatch = GameObject.Find("Design/BunkerHatch/INTERACTIVE_HatchRandomSelect_Prefab");
            if (hatch != null)
            {
                hatch.transform.SetPositionAndRotation(
                    new Vector3(-980.1304f, 214.7899f, 550.7101f),
                    Quaternion.Euler(new Vector3(0f, 197.9656f, 0f))
                );
            }

        }

        private void EnableSandboxResources()
        {
            var barkSpawners = new[]
            {
                "Design/NaturalResources/BranchSpawners/Bark/RadialSpawn_bark",
                "Design/NaturalResources/BranchSpawners/Bark/RadialSpawn_bark (3)"
            };

            foreach (var spawner in barkSpawners)
            {
                var obj = GameObject.Find(spawner);
                if (obj != null)
                {
                    obj.SetActive(true);
                }
            }
        }

        private void EnableWildlifeSpawns()
        {
            var wildlifeSpawns = new[]
            {
                "Wildlife/Plateau/SPAWNREGION_Stag_plateau1",
                "Wildlife/Plateau/SPAWNREGION_Rabbit (5)",
                "Wildlife/Plateau/SPAWNREGION_Rabbit (7)"
            };

            foreach (var spawn in wildlifeSpawns)
            {
                var obj = GameObject.Find(spawn);
                if (obj != null)
                {
                    obj.SetActive(true);
                }
            }
        }

        private void InitializeCanneryRegion()
        {
            SaveDataManager.LoadData();
            new LRManager().PlaceTerrain();

            RepositionDistantMountain();
            SetupCliffCave();
            Clones.ChangeObjects();
            ConfigureHayShed();
        }

        private void RepositionDistantMountain()
        {
            var mountain = GameObject.Find("Art/DistantMountains/TRN_MountainDistantC_Prefab");
            if (mountain != null)
            {
                mountain.transform.SetPositionAndRotation(
                    new Vector3(-1990.195f, -103.2433f, -1391.95f),
                    Quaternion.Euler(new Vector3(3.1792f, 288.5938f, 1.0978f))
                );
            }
        }

        private void SetupCliffCave()
        {
            var cliffObject = GameObject.Find("Art/Objects/Cliffs_Blue_B_CaveShallowA_Nested");
            if (cliffObject != null)
            {
                cliffObject.SetActive(true);
                cliffObject.transform.SetPositionAndRotation(
                    new Vector3(-1015.705f, 283.5386f, 744.48f),
                    Quaternion.Euler(new Vector3(0, 354.5966f, 0))
                );

                // Disable specific child (index 5)
                if (cliffObject.transform.childCount > 5)
                {
                    cliffObject.transform.GetChild(5).gameObject.SetActive(false);
                }
            }
        }

        private void ConfigureHayShed()
        {
            var hayShedClone = GameObject.Find("OBJ_HayShedA_Prefab (2)(Clone)");
            if (hayShedClone != null)
            {
                Utilities.DisableChildrenByIndex("OBJ_HayShedA_Prefab (2)(Clone)", new int[] { 3, 4, 5, 6, 7 });
            }
        }

        private void SetupSandboxPositions()
        {
            var stickSpawnerPositions = new Dictionary<string, Vector3>
            {
                ["Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (82)"] = new Vector3(-1003.33f, 219.02f, 520.78f),
                ["Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (85)"] = new Vector3(-1041.29f, 214.47f, 531.01f),
                ["Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (13)"] = new Vector3(-1083.85f, 180.72f, 446.99f),
                ["Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (1)"] = new Vector3(-1100.79f, 182.59f, 423.94f),
                ["Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (137)"] = new Vector3(-1333.39f, 195.98f, 428.94f),
                ["Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (144)"] = new Vector3(-1363.16f, 201.83f, 484.31f),
                ["Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (101)"] = new Vector3(-1399.20f, 205.11f, 403.27f),
                ["Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (105)"] = new Vector3(-1241.24f, 217.46f, 246.86f)
            };

            var branchSpawnerPositions = new Dictionary<string, Vector3>
            {
                ["Design/NaturalResources/BranchSpawners/BigBranches/RadialSpawn_branches_hard (10)"] = new Vector3(-1241.24f, 217.46f, 246.86f),
                ["Design/NaturalResources/BranchSpawners/BigBranches/RadialSpawn_branches_soft"] = new Vector3(-1102.18f, 187.03f, 462.86f),
                ["Design/NaturalResources/BranchSpawners/BigBranches/RadialSpawn_branches_hard"] = new Vector3(-1378.54f, 196.60f, 403.03f)
            };

            var plantPositions = new Dictionary<string, Vector3>
            {
                ["Design/NaturalResources/Plants/rosehips/INTERACTIVE_RoseHipShrubHarvest (6)"] = new Vector3(-981.09f, 215.88f, 562.17f),
                ["Design/NaturalResources/Plants/rosehips/INTERACTIVE_RoseHipShrubHarvest (7)"] = new Vector3(-976.20f, 215.86f, 560.36f),
                ["Design/NaturalResources/Plants/rosehips/INTERACTIVE_RoseHipShrubHarvest (2)"] = new Vector3(-1364.32f, 184.25f, 340.72f)
            };

            var smallBranchPositions = new Dictionary<string, Vector3>
            {
                ["Design/NaturalResources/BranchSpawners/SmallBranches/RadialSpawn_small_branch (1)"] = new Vector3(-1064.14f, 208.23f, 523.68f),
                ["Design/NaturalResources/BranchSpawners/SmallBranches/RadialSpawn_small_branch (5)"] = new Vector3(-1028.28f, 213.23f, 515.44f),
                ["Design/NaturalResources/BranchSpawners/SmallBranches/RadialSpawn_small_branch (9)"] = new Vector3(-1364.65f, 186.77f, 427.88f),
                ["Design/NaturalResources/BranchSpawners/SmallBranches/RadialSpawn_small_branch (13)"] = new Vector3(-1400.85f, 207.47f, 363.10f)
            };

            var barkPositions = new Dictionary<string, Vector3>
            {
                ["Design/NaturalResources/BranchSpawners/Bark/RadialSpawn_bark"] = new Vector3(-1016.22f, 220.26f, 535.36f),
                ["Design/NaturalResources/BranchSpawners/Bark/RadialSpawn_bark (3)"] = new Vector3(-1017.75f, 220.16f, 534.45f)
            };

            RepositionResourceSpawners(stickSpawnerPositions);
            RepositionResourceSpawners(branchSpawnerPositions);
            RepositionResourceSpawners(plantPositions);
            RepositionResourceSpawners(smallBranchPositions);
            RepositionResourceSpawners(barkPositions);
            SetupMushrooms();
        }

        private void RepositionResourceSpawners(Dictionary<string, Vector3> spawners)
        {
            foreach (var spawner in spawners)
            {
                var obj = GameObject.Find(spawner.Key);
                if (obj != null)
                {
                    obj.transform.SetPositionAndRotation(spawner.Value, Quaternion.identity);
                }
            }
        }

        private void SetupMushrooms()
        {
            var mushroom1 = GameObject.Find("Design/NaturalResources/Plants/mushrooms/INTERACTIVE_ReishiMushroomStump (13)");
            if (mushroom1 != null)
            {
                mushroom1.transform.SetPositionAndRotation(
                    new Vector3(-982.54f, 215.66f, 564.8f),
                    Quaternion.Euler(new Vector3(0, 282.9999f, 0))
                );
                mushroom1.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
            }

            var mushroomPositions = new Dictionary<string, Vector3>
            {
                ["Design/NaturalResources/Plants/mushrooms/INTERACTIVE_ReishiMushroomStump (3)"] = new Vector3(-1349.05f, 206.82f, 489.00f),
                ["Design/NaturalResources/Plants/mushrooms/INTERACTIVE_ReishiMushroomStump (9)"] = new Vector3(-1345.61f, 207.93f, 489.84f)
            };

            foreach (var mushroom in mushroomPositions)
            {
                var obj = GameObject.Find(mushroom.Key);
                if (obj != null)
                {
                    obj.transform.SetPositionAndRotation(
                        mushroom.Value,
                        Quaternion.Euler(new Vector3(0, 282.9999f, 0))
                    );
                }
            }
        }

        private void SetupWildlifePositions()
        {
            var wildlifePositions = new Dictionary<string, Vector3>
            {
                ["Wildlife/Plateau/SPAWNREGION_Rabbit (5)"] = new Vector3(-1051.80f, 212.36f, 525.92f),
                ["Wildlife/Plateau/SPAWNREGION_Rabbit (7)"] = new Vector3(-1097.75f, 188.44f, 473.24f),
                ["Wildlife/Plateau/SPAWNREGION_Stag_plateau1"] = new Vector3(-1357.31f, 187.08f, 439.68f)
            };

            foreach (var wildlife in wildlifePositions)
            {
                var obj = GameObject.Find(wildlife.Key);
                if (obj != null)
                {
                    obj.transform.SetPositionAndRotation(wildlife.Value, Quaternion.identity);
                }
            }
        }
    }
}