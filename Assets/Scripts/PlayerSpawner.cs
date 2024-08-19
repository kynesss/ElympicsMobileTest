using System.Collections.Generic;
using Elympics;
using UnityEngine;

public class PlayerSpawner : ElympicsMonoBehaviour, IServerHandlerGuid, IUpdatable
{
    private const string PrefabPath = "Player";
    
    private readonly Queue<ElympicsPlayer> _playersToSpawn = new();

    public void OnServerInit(InitialMatchPlayerDatasGuid initialMatchPlayerDatas)
    {
     
    }

    public void OnPlayerDisconnected(ElympicsPlayer player)
    {
        
    }

    public void OnPlayerConnected(ElympicsPlayer player)
    { 
        Debug.Log($"Player: {(int)player} connected!");
        _playersToSpawn.Enqueue(player);
    }

    public void ElympicsUpdate()
    {
        if (_playersToSpawn.TryDequeue(out var player))
        {
            SpawnPlayer(player);
        }
    }

    private void SpawnPlayer(ElympicsPlayer player)
    {
        Debug.Log($"Spawn player: {player}");
        ElympicsInstantiate(PrefabPath, player);
    }
}
