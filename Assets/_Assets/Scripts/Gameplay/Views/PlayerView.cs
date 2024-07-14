using _Assets.Scripts.Gameplay.Controllers;
using Pathfinding;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

namespace _Assets.Scripts.Gameplay.Views
{
    public class PlayerView : MonoBehaviour
    {
        private Game _game;
        [SerializeField] private AIPath aiPath;
        private PlayerController _playerController;
        private InputAction _moveAction;

        private void Awake()
        {
            _playerController = new PlayerController(aiPath, transform);

            _game = new Game();
            _game.Enable();
            _moveAction = _game.FindAction("Move");
            _moveAction.performed += MoveTo;
        }

        private void MoveTo(InputAction.CallbackContext callback)
        {
            var position = _moveAction.ReadValue<Vector2>();
            MoveTo(new Vector3(position.x, position.y, 0));
        }

        private void Update()
        {
            _playerController.UpdateModel();
        }

        private void MoveTo(Vector3 position)
        {
            position.z = 10;
            var worldPosition = Camera.main.ScreenToWorldPoint(position);
            worldPosition.z = 0;
            _playerController.MoveTo(worldPosition);
        }
    }
}