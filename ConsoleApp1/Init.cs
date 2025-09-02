using Raylib_cs;
using static Raylib_cs.Raylib;



namespace SceneSys
{
    class Init
    {

        IScene sceneGamePlay;
        IScene sceneMenu;
        IScene sceneOption;
        IScene currentScene;
        IGrid grid;
        GameState gameState;

        //singleton
        private static Init? instance;
       
        public static Init Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Init();
                }

                return instance;
            }
        }


        // constructeur qui bloque les instanciation ext
        private Init(){

            // dip dependecy inversion principe les modules haut et bas ne doivent dépendre que d'abstraction
            sceneMenu = new SceneMenu();
            sceneGamePlay = new SceneGamePlay();
            sceneOption = new SceneOption();
            grid = new Grid(5, 3, 75, 75);
         
            //Singleton
            gameState = GameState.Instance;

            gameState.RegisterScene(EnumType.Scene.Menu, sceneMenu);
            gameState.RegisterScene(EnumType.Scene.GamePlay, sceneGamePlay);
            gameState.RegisterScene(EnumType.Scene.Option, sceneOption);

            gameState.ChangeScene(EnumType.Scene.Menu);


        }

        public void OnInit(){}

        public void Update()
        {
            gameState.UpdateScene();
        }

        public void Draw()
        {
            gameState.DrawScene();
            grid.Draw();
          
        }

        public void RemoveScene()
        {
            gameState.RemoveScene();

        }

    }
}
