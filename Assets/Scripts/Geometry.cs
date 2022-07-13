using UnityEngine;

public class Geometry
{
    static public Vector3 PointFromGrid(Vector2Int gridPoint) => 
        new Vector3(-3.5f + 1.0f * gridPoint.x, 0, -3.5f + 1.0f * gridPoint.y);

    static public Vector2Int GridPoint(int col, int row) => new Vector2Int(col, row);

    static public Vector2Int GridFromPoint(Vector3 point) => 
        new Vector2Int(Mathf.FloorToInt(4.0f + point.x), Mathf.FloorToInt(4.0f + point.z));
}
