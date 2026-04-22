using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int waterScore = 0;
    public int soilScore = 0;
    public int animalsScore = 0;
    public int plantsScore = 0;

    private void Awake()
    {
        // Zorgt dat er maar 1 instance is
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddWater(int amount)
    {
        waterScore += amount;
        Debug.Log("Water score: " + waterScore);
    }

    public void AddSoil(int amount)
    {
        soilScore += amount;
        Debug.Log("Soil score: " + soilScore);
    }

    public void AddAnimals(int amount)
    {
        animalsScore += amount;
        Debug.Log("Animals score: " + animalsScore);
    }

    public void AddPlants(int amount)
    {
        plantsScore += amount;
        Debug.Log("Plants score: " + plantsScore);
    }
}