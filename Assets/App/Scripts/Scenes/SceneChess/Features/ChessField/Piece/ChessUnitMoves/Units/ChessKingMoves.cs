using Assets.App.Scripts.Scenes.SceneChess.Features.ChessField.Types;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.App.Scripts.Scenes.SceneChess.Features.ChessField.Piece.ChessUnitMoves.Units
{
    public class ChessKingMoves : ChessUnitMoves, IChessUnitMovesProvider
    {
        private readonly List<ChessUnitMoveDirection> _directions = new()
            {
                { ChessUnitMoveDirection.TOP }, { ChessUnitMoveDirection.RIGHT },
                { ChessUnitMoveDirection.BOTTOM }, { ChessUnitMoveDirection.LEFT },
            };
        private readonly int _countSteps = 1;

        public ChessKingMoves()
        {
        }

        public Dictionary<ChessUnitMoveDirection, List<Vector2Int>> GetMoves()
        {

            return CreateMovesForUnit(_directions, _countSteps);
        }
    }
}