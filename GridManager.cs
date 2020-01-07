using System;
using System.Collections.Generic;
using UnityEngine;


public class GridManager : MonoBehaviour
{
    //grid specifics
    [SerializeField]
    private int rows;
    [SerializeField]
    private int cols;
    [SerializeField]
    private Vector2 gridSize;
    [SerializeField]
    private Vector2 gridOffset;
    [SerializeField]
    private int offsetX;
    [SerializeField]
    private int offsetZ;
    [SerializeField]
    private List<Vector3> gridPosition;
    
    [SerializeField]
    private Sprite cellSprite;
    private Vector3 cellSize;
    private Vector3 cellScale;
    public Vector3 pos;

    public GameObject blockPrefab;
    void Start()
    {
        CreateGrid();
    }

    void CreateGrid()
    {
        GameObject cellObject = new GameObject();  
        cellObject.AddComponent<SpriteRenderer>().sprite = cellSprite;
        cellSize = cellSprite.bounds.size;
    
        Vector3 newCellSize = new Vector3(gridSize.x / (float)cols, gridSize.y / (float)rows,90);
    
        cellScale.x = newCellSize.x / cellSize.x;
        cellScale.y = newCellSize.y / cellSize.y;
        cellScale.z = newCellSize.z / cellSize.z;
        cellSize = newCellSize; 

        cellObject.transform.localScale = new Vector3(cellScale.x, cellScale.y,cellScale.z);
        
        gridOffset.x = -(gridSize.x / 2) + cellSize.x / 2;
        gridOffset.y = -(gridSize.y / 2) + cellSize.y / 2;

        int indexNo = 0; 

        for (int row = 0; row < rows; row++)
        {
            indexNo++;
            for (int col = 0; col < cols; col++)
            {
                indexNo++;
               
                pos = new Vector3(offsetX * col * cellSize.x + gridOffset.x + transform.position.x, 0, offsetZ * row * cellSize.y + gridOffset.y + transform.position.y);


                
                GameObject createGrid = Instantiate(cellObject, pos, Quaternion.identity) as GameObject;

                
                createGrid.transform.parent = transform;
                createGrid.transform.eulerAngles = new Vector3(90, transform.position.y, transform.position.z);
                gridPosition[indexNo] = pos;

                GameObject createBlock = Instantiate(blockPrefab,gridPosition[indexNo],Quaternion.identity);

            }

        }
       
        Destroy(cellObject);
    }

  
}
