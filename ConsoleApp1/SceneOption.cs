using Raylib_cs;
using System;
using static Raylib_cs.Raylib;
using static SceneSys.EnumType;

namespace SceneSys
{
    class SceneOption : IScene
    {
        public string Name { get; set; }


        public void Draw()
        {
            DrawText("Voici les options", 50, GetScreenHeight() / 2, 35, Color.RayWhite);

        }


        public void Update()
        {
            if (IsKeyPressed(KeyboardKey.Escape))
            {
                GameState.Instance.ChangeScene(EnumType.Scene.Menu);
            }
        }
    }
}
