using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense
{
    public class Grid : MonoBehaviour
    {
        private Dictionary<Vector3Int, GameObject> gameObjects = new Dictionary<Vector3Int, GameObject>();

        public bool Occupied (Vector3Int tileCoordinates)
        {
            return gameObjects.ContainsKey( tileCoordinates );
        }
        public bool Add(Vector3Int tileCoordinates, GameObject gameObject)
        {
            if (gameObjects.ContainsKey(tileCoordinates)) return false;

            gameObjects.Add(tileCoordinates, gameObject);
            return true;
        }

        public void Remove(Vector3Int tileCoordinates)
        {
            if (!gameObjects.ContainsKey(tileCoordinates)) { return; }

            Destroy(gameObjects[tileCoordinates]);
            gameObjects.Remove(tileCoordinates);
        }

        public static Vector3Int WorldToGrid(Vector3 worldPostion)
        {
            int x = Mathf.FloorToInt(worldPostion.x);
            int y = Mathf.FloorToInt(worldPostion.y);
            int z = Mathf.FloorToInt(worldPostion.z);

            return new Vector3Int(x, y, z);
        }

        public static Vector3 GridToWorld(Vector3Int gridPosition)
        {
            float x = gridPosition.x * 1 + 1 / 2f;
            float y = gridPosition.y * 1 + 1 / 2f;
            float z = gridPosition.z * 1 + 1 / 2f;

            return new Vector3(x, y, z);    

        }
    }
}


