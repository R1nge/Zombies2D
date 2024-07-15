using _Assets.Scripts.Gameplay.Controllers;
using Pathfinding;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _Assets.Scripts.Gameplay.Views
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private AIPath aiPath;
        private Game _game;
        private PlayerController _playerController;
        private InputAction _setDestinationAction;
        private InputAction _moveToDestinationAction;
        private Camera _playerCamera;

        private void Awake()
        {
            _playerCamera = Camera.main;

            _playerController = new PlayerController(aiPath, transform);

            _game = new Game();
            _game.Enable();

            _setDestinationAction = _game.FindAction("SetDestination");
            _setDestinationAction.performed += SetDestination;

            _moveToDestinationAction = _game.FindAction("MoveToDestination");
            _moveToDestinationAction.performed += MoveToDestination;
        }

        private void MoveToDestination(InputAction.CallbackContext callback)
        {
            _playerController.MoveToDestination();
        }

        private void SetDestination(InputAction.CallbackContext callback)
        {
            var position = _setDestinationAction.ReadValue<Vector2>();
            SetDestination(position);
        }

        private void Update()
        {
            _playerController.UpdateModel();
        }

        private void SetDestination(Vector3 position)
        {
            position.z = 10;
            var worldPosition = _playerCamera.ScreenToWorldPoint(position);
            worldPosition.z = 0;
            _playerController.SetDestination(worldPosition);
        }

        private void OnDestroy()
        {
            _setDestinationAction.performed -= SetDestination;
            _moveToDestinationAction.performed -= MoveToDestination;
            _game?.Dispose();
        }
    }
}