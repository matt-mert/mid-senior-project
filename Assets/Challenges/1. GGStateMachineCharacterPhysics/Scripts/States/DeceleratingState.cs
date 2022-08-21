using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using GGPlugins.GGStateMachine.Scripts.Abstract;
using UnityEngine;

namespace Challenges._1._GGStateMachineCharacterPhysics.Scripts.States
{
    public class DeceleratingState : GGStateBase
    {
        private readonly MonoBehaviours.CharacterController _controller;
        private readonly MonoBehaviours.CharacterMovementConfig _config;

        public DeceleratingState(MonoBehaviours.CharacterController controller, MonoBehaviours.CharacterMovementConfig config)
        {
            _controller = controller;
            _config = config;
        }

        public override void Setup()
        {
            
        }

        public override async UniTask Entry(CancellationToken cancellationToken)
        {
            await UniTask.Delay(TimeSpan.FromSeconds(2f), cancellationToken: cancellationToken);
        }

        public override async UniTask Exit(CancellationToken cancellationToken)
        {
            Debug.Log("ExampleState: Exit");
        }

        public override void CleanUp()
        {

        }
    }
}