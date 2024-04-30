using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinding
{
   /* private const int MOVE_STRAIGHT_COST = 10;
    private const int MOVE_DIAGONAL_COST = 14;

    private Grid<PathNode> _grid;
    private List<PathNode> _openList;
    private List<PathNode> _closedList;
    public Pathfinding(int width, int height)
    {
        _grid = new Grid<PathNode>(width, height, 10f, Vector3.zero, (Grid<PathNode> g, int x, int y) => new PathNode(g, x, y));
    }
    private List<PathNode>  FindPath(int startX, int startY, int endX, int endY)
    {

        PathNode startNode = _grid.GetGridObject(startX, startY);
        PathNode endNode = _grid.GetGridObject(endX, endY);

        _openList = new List<PathNode>() { startNode };
        _closedList = new List<PathNode>();

        for (int x = 0; x < _grid.GetWidth(); x++)
        {
            for (int y = 0; y < _grid.GetHeight(); y++)
            {
                PathNode pathNode = Grid.GetGridObject(x, y);
                PathNode.gCost = int.MaxValue;
                PathNode.CalculateFCost();
                PathNode.cameFromNode = null;
            }
        }

        startNode.gCost = 0;
        startNode.hCost = CalculateDistanceCost(startNode, endNode);
        startNode.CalculateFCost();

        while (_openList.Count > 0)
        {
            PathNode currentNode
        }
    }

    private int CalculateDistanceCost(PNode a, PNode b)
    {
        int XDistance = Mathf.Abs(a.x - b.x);
        int YDistance = Mathf.Abs(a.y - b.y);
        int remaining = Mathf.Abs(XDistance - YDistance);

        return MOVE_DIAGONAL_COST * Mathf.Min(XDistance, YDistance) + MOVE_STRAIGHT_COST * remaining;
    }

    private PathNode GetLowestFCostNode(List<PathNode> pathNodeList)
    {
        PathNode lowestFCostNode = pathNodeList[0];

        for (int i = 1; i < pathNodeList.Count; i++)
        {
            if()
        }
    }*/
}
