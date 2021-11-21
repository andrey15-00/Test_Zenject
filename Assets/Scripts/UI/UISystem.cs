using System;
using System.Collections.Generic;

namespace UnityGame
{
    public class UISystem : IUISystem
    {
        private List<UIScreen> _screens;

        public void Init(List<UIScreen> screens)
        {
            _screens = screens;
        }

        public void ShowScreen<T>() where T: UIScreen
        {
            UIScreen screen = GetScreen<T>();
            screen.Show();
        }

        public void HideScreen<T>() where T : UIScreen
        {
            UIScreen screen = GetScreen<T>();
            screen.Hide();
        }

        public T GetScreen<T>() where T: UIScreen
        {
            Type type = typeof(T);
            foreach (var screen in _screens)
            {
                if (screen.GetType() == type)
                {
                    return (T)screen;
                }
            }

            throw new Exception($"Screen with type {type} not found!");
        }
    }
}
