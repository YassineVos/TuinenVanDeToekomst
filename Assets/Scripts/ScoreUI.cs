using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private void Update()
    {
        if (ScoreManager.Instance == null)
            return;

        scoreText.text =
            "Water in bodem: " + ScoreManager.Instance.waterScore + "\n" +
            "Gezonde bodem: " + ScoreManager.Instance.soilScore + "\n" +
            "Dieren: " + ScoreManager.Instance.animalsScore + "\n" +
            "Plantdiversiteit: " + ScoreManager.Instance.plantsScore;
    }
}