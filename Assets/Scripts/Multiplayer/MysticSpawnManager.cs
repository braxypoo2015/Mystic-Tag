using UnityEngine;

public class MysticSpawnManager : MonoBehaviour
{
    [Header("Spawn Points")]
    public Transform[] spawnPoints;

    public Transform SpawnPlayer(GameObject player)
    {
        if (player == null || spawnPoints == null || spawnPoints.Length == 0)
        {
            Debug.LogWarning("No player or spawn points available!");
            return null;
        }

        Transform spawn = spawnPoints[
            Random.Range(0, spawnPoints.Length)
        ];

        player.transform.SetPositionAndRotation(
            spawn.position,
            spawn.rotation
        );

        Debug.Log("Player spawned successfully!");

        return spawn;
    }
}
