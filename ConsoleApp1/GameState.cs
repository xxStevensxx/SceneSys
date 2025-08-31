using Raylib_cs;
using static Raylib_cs.Raylib;
using System.Diagnostics;

namespace SceneSys
{
    class GameState
    {

        //Singleton
        private static GameState? instance;

        private IScene? currentScene;

        // Init GameState Instance
        public static GameState Instance
        {
            get{
                
                if (instance == null)
                {
                    instance = new GameState();
                }

                return instance;
            }

        }


        private Dictionary<Enum, IScene> scenes;


        //Constructeur
        public GameState() {

            scenes = new Dictionary<Enum, IScene>();

        }

        public void RegisterScene(Enum eName, IScene scene) {

            scenes[eName] = scene;
  
        }

        public void ChangeScene(Enum enumId)
        {
            if (scenes.ContainsKey(enumId))
            {
                scenes[enumId].Show();
                currentScene = scenes[enumId];
                //currentScene.Show();
                Debug.WriteLine($"current scene {enumId}");
                Debug.WriteLine($"Changement de Scene: {enumId} ");
            }
            else
            {
                string error = $"scene {enumId} non trouvé dans le dico";
                Debug.WriteLine(error);
            }
        }

        public void UpdateScene()
        {
            currentScene?.Update();
        }

        public void DrawScene()
        {
            currentScene?.Draw();
        }
    }
}
