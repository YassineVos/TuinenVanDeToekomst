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
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScores(int water, int soil, int animals, int plants)
    {
        waterScore += water;
        soilScore += soil;
        animalsScore += animals;
        plantsScore += plants;

        Debug.Log("Scores bijgewerkt:");
        Debug.Log("Water in bodem: " + waterScore);
        Debug.Log("Gezonde bodem: " + soilScore);
        Debug.Log("Dieren: " + animalsScore);
        Debug.Log("Plantdiversiteit: " + plantsScore);
    }
}