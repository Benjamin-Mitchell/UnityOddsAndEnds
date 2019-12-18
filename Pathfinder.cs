using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Aim of this class:
// Describe the trilateral movement of an agent across a 3D grid, with obstacle avoidance.

// Initial implementation only works for uniform size colliders (cube, sphere etc)
public class Pathfinder : MonoBehaviour
{
    struct Node
    {
        int x, y;
    }

    public static int gridSize = 500;
    public static float nodeSize = 1.0f;
    public static Vector3 centrePos = new Vector3(0.0f, 0.0f, 0.0f);

    public List<GameObject> obstacles;
    public List<GameObject> agents;
    
    Node[,] grid = new Node[gridSize, gridSize];

    void Awake()
    {
        transform.position = centrePos;

        //inital population of lists.
        obstacles = new List<GameObject>(GameObject.FindGameObjectsWithTag("obstacle"));
        agents = new List<GameObject>(GameObject.FindGameObjectsWithTag("agent"));

        //populate grid with inital objects.
        UpdateGridWithObstacles();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void UpdateGridWithObstacles()
    {
        foreach (GameObject obj in obstacles)
        {
            // transform 
            Vector3 pos = obj.transform.position;

            // can use the collider's size to determine which grid cells the obstacle overlaps
            // then update the grid accordingly.


        }
    }
}
