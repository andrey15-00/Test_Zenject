using System.Collections.Generic;

namespace UnityGame
{
    public interface IUISystem
    {
        public void Init(List<UIScreen> screens);
        public void ShowScreen<T>() where T : UIScreen;
        public void HideScreen<T>() where T : UIScreen;
        public T GetScreen<T>() where T : UIScreen;
    }
}
