using Raylib_cs;
using SceneSys;
using static Raylib_cs.Raylib;
using static SceneSys.Init;


class Program()
{

    public static int Main()
    {

        InitWindow(800, 600, "Scene");
        SetTargetFPS(60);
        SetExitKey(KeyboardKey.Null);
       

        while (!WindowShouldClose()) {
            Init.Instance.Update();
            BeginDrawing();
            //Init.Instance.Initializing();
            ClearBackground(Color.Black);
            Init.Instance.Draw();
            EndDrawing();

        }

        Init.Instance.RemoveScene();
        CloseWindow();
        return 0;
    }

}