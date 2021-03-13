using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour
{

    public GameObject foodPrefab;

    public float xSize = 8.8f;
    public float zSize = 8.8f;

    public GameObject currentFood;

    public Vector3 currentPosition;

    // Start is called before the first frame update
    void Start()
    {
        randomPosition();
        currentFood = Instantiate(foodPrefab, currentPosition, Quaternion.identity);
    }

    void randomPosition()
    {
        currentPosition = new Vector3(Random.Range(-xSize, xSize), 0.25f, Random.Range(-zSize, zSize));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
