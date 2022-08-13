using Challenges._2._ModifiedSnake.Scripts.Abstract;
using Challenges._2._ModifiedSnake.Scripts.Data;
using UnityEngine;
using Zenject;

namespace Challenges._2._ModifiedSnake.Scripts.Blocks
{
    /// <summary>
    /// The platform blocks of the bridge.
    /// </summary>
    public class BridgePlatformBlock : MonoBehaviour
    {
        public class BridgePlatformBlockPool : MonoMemoryPool<Vector2Int, BridgePlatformBlock>
        {
            protected override void OnSpawned(BridgePlatformBlock item)
            {
                base.OnSpawned(item);
            }

            protected override void OnDespawned(BridgePlatformBlock item)
            {
                base.OnDespawned(item);
                item._occupancyHandler.ClearOccupancy(item._position);
            }

            protected override void Reinitialize(Vector2Int p1, BridgePlatformBlock item)
            {
                base.Reinitialize(p1, item);
                item._position = p1;
                item.transform.position = item._map.ToWorldPosition(p1);
                item._occupancyHandler.SetOccupied(item._position, OccupancyType.None);
            }
        }

        [Inject]
        protected readonly IOccupancyHandler _occupancyHandler;
        [Inject]
        protected readonly IMap _map;
        protected Vector2Int _position;

        public Vector2Int Position => _position;
    }
}