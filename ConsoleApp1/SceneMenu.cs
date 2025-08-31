using Raylib_cs;
using static Raylib_cs.Raylib;
using static SceneSys.EnumType;

namespace SceneSys
{
    class SceneMenu : IScene
    {
        public string Name { get; set; }

        public void Draw() {

            DrawText("Bonjour je suis le Menu ", 50, GetScreenHeight() / 2, 35, Color.RayWhite);

        }


        public void Update()
        {

            if (IsKeyPressed(KeyboardKey.Space)) {

                GameState.Instance.ChangeScene(EnumType.Scene.GamePlay);

            }

            if (IsKeyPressed(KeyboardKey.O))
            {

                GameState.Instance.ChangeScene(EnumType.Scene.Option);

            }
        }
        
    }
}
