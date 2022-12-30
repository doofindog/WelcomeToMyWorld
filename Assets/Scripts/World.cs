using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.Mathematics;
using UnityEngine;

public class World : MonoBehaviour
{
    public int size;
    WorldGenerator generator;
    Dictionary<int, Plot> plots;

    public static World Instance { get; private set; }

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        generator = GetComponent<WorldGenerator>();
        plots = new Dictionary<int, Plot>();
    }

    public void Start()
    {
        plots = generator.GeneratePlot(size);
        generator.GenerateTrees(size);
    }

}
