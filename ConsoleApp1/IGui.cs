

namespace SceneSys
{
    interface IGui<T>
    {

        void IsClicked() {}
        void Quit() {}
        void IsHover() {}
        void AddElement(T element) {}
    }
}
