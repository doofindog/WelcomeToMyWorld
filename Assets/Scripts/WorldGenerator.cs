using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    [Header("Ground")]
    public GameObject plotPrefab;
    public Sprite[] plotSprite;
    public Vector3 plotPosition;

    [Header("Trees")]
    public GameObject treePrefab;
    public Sprite[] treeSprite;
    public Vector3 treePosition;
    [Range(0,100)] public float frequncy;

    public Dictionary<int,Plot> GeneratePlot(int worldSize)
    {
        Dictionary<int, Plot> plots = new Dictionary<int, Plot>();
        for (int index = -worldSize; index <= worldSize; index++)
        {
            Vector3 position = new Vector3(index, 0, 0) + plotPosition;
            GameObject plotObj = Instantiate(plotPrefab, position, Quaternion.identity);
            plotObj.GetComponent<SpriteRenderer>().sprite = plotSprite[Mathf.Abs(index) % plotSprite.Length];
            plotObj.transform.parent = transform;

            Plot plot = new Plot(index, plotObj, false, position);
            plots.Add(index, plot);
        }
        return plots;
    }

    public void GenerateTrees(int worldSize)
    {
        for (int index = -worldSize; index <= worldSize; index++)
        {
            float value = Mathf.InverseLerp(-worldSize, worldSize, index) * frequncy;
            float perlinValue = Mathf.PerlinNoise(value, 1);

            perlinValue = Mathf.Lerp(0, 10, Mathf.InverseLerp(0, 1, perlinValue));
            if (perlinValue > 4.5)
            {
                Vector3 position = new Vector3(index, -2.5f, 0);
                GameObject tree = Instantiate(treePrefab, position, Quaternion.identity);
            }

        }
    }

}

public class Plot
{
    int index;
    GameObject obj;
    bool isOccupied;
    Vector3 position;

    public Plot(int index, GameObject obj, bool isOccupied, Vector3 position)
    {
        this.index = index;
        this.obj = obj;
        this.isOccupied = isOccupied;
        this.position = position;
    }
}
