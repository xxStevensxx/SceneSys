using Raylib_cs;
using System;
using static Raylib_cs.Raylib;
using static SceneSys.EnumType;

namespace SceneSys
{
    class SceneGamePlay : IScene
    {
        public string Name { get; set; }

        public void Draw()
        {
            DrawText("Bonjour je suis le GamePlay", 50, GetScreenHeight() / 2, 35, Color.RayWhite);
        }

        public void Show()
        {

            Console.WriteLine($"Show scene{EnumType.Scene.GamePlay}");
        }


        public void Hide()
        {

            Console.WriteLine($"Hide scene{EnumType.Scene.GamePlay}");
        }


        public void Close()
        {

            Console.WriteLine($"Close scene{EnumType.Scene.GamePlay}");

        }
        public void Update() {

            if (IsKeyPressed(KeyboardKey.M)) {

                GameState.Instance.ChangeScene(EnumType.Scene.Menu);

            }
        }

    }
}
