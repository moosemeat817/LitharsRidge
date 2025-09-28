using MelonLoader.Utils;
using UnityEngine.Rendering.PostProcessing;


namespace LitharsRidge
{

    public class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            Settings.OnLoad();    // ModSettings
        }



        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {

            
            if (sceneName == "CanneryRegion" && Settings.options.litharTower)
            {

                GameObject.Find("Wildlife/Plateau/SPAWNREGION_Rabbit (5)").gameObject.SetActive(true);
                GameObject.Find("Wildlife/Plateau/SPAWNREGION_Rabbit (7)").gameObject.SetActive(true);


            }
            


            }


        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            
            if (sceneName == "CanneryRegion" && Settings.options.litharEnabled)
            {
                SaveDataManager.LoadData();
                new LRManager().PlaceTerrain();
            }




            /*
            if(sceneName == "CanneryRegion" && Settings.options.litharEnabled)
            {
                new LRManager().PlaceAssets();
            }
            */


            /*
            if (sceneName == "CanneryRegion_SANDBOX" && Settings.options.litharEnabled)
            {
                Clones.ChangeObjects();
            }
            */

            if (sceneName == "CanneryRegion" && Settings.options.litharEnabled)
            {


                GameObject.Find("Art/DistantMountains/TRN_MountainDistantC_Prefab").transform.SetPositionAndRotation(new Vector3(-1990.195f, -103.2433f, -1391.95f), Quaternion.Euler(new Vector3(3.1792f, 288.5938f, 1.0978f)));



                GameObject cliffObject = GameObject.Find("Art/Objects/Cliffs_Blue_B_CaveShallowA_Nested");
                cliffObject.SetActive(true);
                cliffObject.transform.SetPositionAndRotation(new Vector3(-1015.705f, 283.5386f, 744.48f), Quaternion.Euler(new Vector3(0, 354.5966f, 0)));

                // Disable child 2 and children 4-10
                int[] childrenToDisable = { 5 };
                foreach (int childIndex in childrenToDisable)
                {
                    if (childIndex < cliffObject.transform.childCount)
                    {
                        cliffObject.transform.GetChild(childIndex).gameObject.SetActive(false);
                    }
                }



                Clones.ChangeObjects();

                Utilities.DisableChildrenByIndex("OBJ_HayShedA_Prefab (2)(Clone)", new int[] { 3, 4, 5, 6, 7 });

            }




            if (sceneName == "CanneryRegion_SANDBOX" && Settings.options.litharEnabled)
            {

                GameObject.Find("Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (82)").transform.SetPositionAndRotation(new Vector3(-1003.33f, 219.02f, 520.78f), Quaternion.Euler(new Vector3(0, 0, 0)));

                GameObject.Find("Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (85)").transform.SetPositionAndRotation(new Vector3(-1041.29f, 214.47f, 531.01f), Quaternion.Euler(new Vector3(0, 0, 0)));

                GameObject.Find("Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (13)").transform.SetPositionAndRotation(new Vector3(-1083.85f, 180.72f, 446.99f), Quaternion.Euler(new Vector3(0, 0, 0)));

                GameObject.Find("Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (1)").transform.SetPositionAndRotation(new Vector3(-1100.79f, 182.59f, 423.94f), Quaternion.Euler(new Vector3(0, 0, 0)));

                GameObject.Find("Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (137)").transform.SetPositionAndRotation(new Vector3(-1333.39f, 195.98f, 428.94f), Quaternion.Euler(new Vector3(0, 0, 0)));

                GameObject.Find("Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (144)").transform.SetPositionAndRotation(new Vector3(-1363.16f, 201.83f, 484.31f), Quaternion.Euler(new Vector3(0, 0, 0)));

                GameObject.Find("Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (101)").transform.SetPositionAndRotation(new Vector3(-1399.20f, 205.11f, 403.27f), Quaternion.Euler(new Vector3(0, 0, 0)));

                GameObject.Find("Design/NaturalResources/BranchSpawners/Sticks/Delta/RadialSpawn_sticks (105)").transform.SetPositionAndRotation(new Vector3(-1241.24f, 217.46f, 246.86f), Quaternion.Euler(new Vector3(0, 0, 0)));



                GameObject.Find("Design/NaturalResources/BranchSpawners/BigBranches/RadialSpawn_branches_hard (10)").transform.SetPositionAndRotation(new Vector3(-1241.24f, 217.46f, 246.86f), Quaternion.Euler(new Vector3(0, 0, 0)));

                GameObject.Find("Design/NaturalResources/BranchSpawners/BigBranches/RadialSpawn_branches_soft").transform.SetPositionAndRotation(new Vector3(-1102.18f, 187.03f, 462.86f), Quaternion.Euler(new Vector3(0, 0, 0)));


                GameObject.Find("Design/NaturalResources/Plants/rosehips/INTERACTIVE_RoseHipShrubHarvest (6)").transform.SetPositionAndRotation(new Vector3(-981.09f, 215.88f, 562.17f), Quaternion.Euler(new Vector3(0, 0, 0)));

                GameObject.Find("Design/NaturalResources/Plants/rosehips/INTERACTIVE_RoseHipShrubHarvest (7)").transform.SetPositionAndRotation(new Vector3(-976.20f, 215.86f, 560.36f), Quaternion.Euler(new Vector3(0, 0, 0)));

                GameObject.Find("Design/NaturalResources/Plants/mushrooms/INTERACTIVE_ReishiMushroomStump (13)").transform.SetPositionAndRotation(new Vector3(-982.54f, 215.66f, 564.8f), Quaternion.Euler(new Vector3(0, 282.9999f, 0)));
                GameObject.Find("Design/NaturalResources/Plants/mushrooms/INTERACTIVE_ReishiMushroomStump (13)").gameObject.transform.localScale = new Vector3(.9f, .9f, .9f);


                GameObject.Find("Design/NaturalResources/BranchSpawners/SmallBranches/RadialSpawn_small_branch (1)").transform.SetPositionAndRotation(new Vector3(-1064.14f, 208.23f, 523.68f), Quaternion.Euler(new Vector3(0, 0, 0)));
                GameObject.Find("Design/NaturalResources/BranchSpawners/SmallBranches/RadialSpawn_small_branch (5)").transform.SetPositionAndRotation(new Vector3(-1028.28f, 213.23f, 515.44f), Quaternion.Euler(new Vector3(0, 0, 0)));
                GameObject.Find("Design/NaturalResources/BranchSpawners/SmallBranches/RadialSpawn_small_branch (9)").transform.SetPositionAndRotation(new Vector3(-1364.65f, 186.77f, 427.88f), Quaternion.Euler(new Vector3(0, 0, 0)));
                GameObject.Find("Design/NaturalResources/BranchSpawners/SmallBranches/RadialSpawn_small_branch (13)").transform.SetPositionAndRotation(new Vector3(-1400.85f, 207.47f, 363.10f), Quaternion.Euler(new Vector3(0, 0, 0)));


                

            }




            if (sceneName == "CanneryRegion_SANDBOX_WILDLIFE" && Settings.options.litharEnabled)
            {

                

                GameObject.Find("Wildlife/Plateau/SPAWNREGION_Rabbit (5)").transform.SetPositionAndRotation(new Vector3(-1051.80f, 212.36f, 525.92f), Quaternion.Euler(new Vector3(0, 0, 0)));
                GameObject.Find("Wildlife/Plateau/SPAWNREGION_Rabbit (7)").transform.SetPositionAndRotation(new Vector3(-1097.75f, 188.44f, 473.24f), Quaternion.Euler(new Vector3(0, 0, 0)));

                GameObject.Find("Wildlife/Plateau/SPAWNREGION_Stag_plateau1").gameObject.SetActive(true);
                GameObject.Find("Wildlife/Plateau/SPAWNREGION_Stag_plateau1").transform.SetPositionAndRotation(new Vector3(-1357.31f, 187.08f, 439.68f), Quaternion.Euler(new Vector3(0, 0, 0)));
                


            }



        }


    }
}
