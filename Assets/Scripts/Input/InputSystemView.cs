using System;
using UnityEngine;
using Zenject;

namespace UnityGame
{
    public class InputSystemView : MonoBehaviour
    {
        [Inject] private IInputSystem _model;

        private void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            if(horizontal != 0 || vertical != 0)
            {
                _model.PublishMove(new Vector2(vertical, horizontal));
            }
        }
    }
}
