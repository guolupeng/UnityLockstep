﻿using BEPUutilities;
using ECS.Data;
using Entitas;

namespace ECS
{
    public interface IService
    {

    }
                    
    public interface IGridService : IService
    {
        Vector2 GetWorldSize();
        Vector2 GetCellSize();        
    }            

    public interface IParseInputService : IService
    {
        void Parse(GameContext context, SerializedInput serializedInput);
    }

    public interface IGameService : IService
    {                                                        
        void ApplyEntity(GameEntity entity, int configId);
    }

    public interface INavigationService : IService
    {
        void AddAgent(int id, Vector2 position);

        void SetAgentDestination(int agentId, Vector2 newDestination);
                                                                 
        void UpdateAgents();

        Vector2 GetAgentPosition(int agentId);
    }

    public interface IHashService : IService
    {  
        long GetHashCode(GameEntity entity);
    }
      
    public interface ILogService : IService
    {
        void Warn(string message);
    }
}