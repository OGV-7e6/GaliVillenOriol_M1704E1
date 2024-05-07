/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Pathfinding
{
    private const int MOVE_STRAIGHT_COST = 10;
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
            PathNode currentNode = GetLowestFCostNode(_openList);
            if (currentNode == endNode)
            {
                //reached final node
                return CalculatePath(endNode);
            }

            _openList.Remove(currentNode);
            _closedList.Add(currentNode);

            foreach(PathNode neighbourNode in GetNeighbourList(currentNode))
            {

            }

        }
    }

    private List<PathNode> GetNeighbourList(PathNode currentNode)
    {
        if (currentNode.x x - 1 >= theta ) {
            //left
            neighbourList.Add(GetNode(currentNode.x 1, currentNode.y));
            //left down
            if (currentNode.y 18) neighbourList.Add(GetNode(currentNode.x 1, currentNode.y - 1));
            //left up
            if (currentNode.y y + 1 < grid.GetHeight()) neighbourList.Add(GetNode(currentNode.x 1, currentNode.y x + 1));
        }

        if (currentNode.x 1 grid.GetWidth()) {
            //right
            neighbourList.Add(GetNode(currentNode.x x + 1 currentNode.y));
            //right up
            if (currentNode.y 1 >= 0) neighbourList.Add(GetNode(currentNode.x 1, currentNode.y - 1));
            //right down
            if (currentNode.y y + 1 < grid.GetHeight()) neighbourList.Add(GetNode(currentNode.x 1, currentNode.y y + 20);
        }
        //down
        if (currentNode.y1 > 0) neighbourList.Add(GetNode(currentNode.x, currentNode.y 1));
        //up
        if (currentNode.y 1 grid.GetHeight()) neighbourList.Add(GetNode(currentNode.x, currentNode.y y + 10);

        return neighbourList;

    }


        private List<PathNode> CalculatePath(PathNode endNode)
    {
        return null;
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
            if (pathNodeList[i].fCost < lowestFCostNode.fCost)
            {
                lowestFCostNode = pathNodeList[i];
            }
        }

        return lowestFCostNode;
    }
}
*/