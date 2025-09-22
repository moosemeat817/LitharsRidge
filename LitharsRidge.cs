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

            /*
            if (sceneName == "CanneryRegion" && Settings.options.litharEnabled)
            {

                GameObject.Find("Art/Rocks/INTERACTIVE_RopeCliff_08_100m/Rope_100m").gameObject.SetActive(true);           

            }
            */

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

            

            if (sceneName == "CanneryRegion_SANDBOX" && Settings.options.litharEnabled)
            {
                Clones.ChangeObjects();
            }

            if (sceneName == "CanneryRegion" && Settings.options.litharEnabled)
            {
                Clones.ChangeObjects();
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









            }






        }


    }
}
