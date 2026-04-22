using UnityEngine;
using TMPro;

public class EndUIManager : MonoBehaviour
{
    public static EndUIManager Instance;

    public GameObject endPanel;
    public TextMeshProUGUI resultText;

    private void Awake()
    {
        Instance = this;
        endPanel.SetActive(false);
    }

    public void ShowEndScreen()
    {
        int water = ScoreManager.Instance.waterScore;
        int soil = ScoreManager.Instance.soilScore;
        int animals = ScoreManager.Instance.animalsScore;
        int plants = ScoreManager.Instance.plantsScore;

        string feedback = GetFeedback(water, soil, animals, plants);

        resultText.text =
            "Water in bodem: " + water + "\n" +
            "Gezonde bodem: " + soil + "\n" +
            "Dieren: " + animals + "\n" +
            "Plantdiversiteit: " + plants + "\n\n" +
            "Feedback:\n" + feedback;

        endPanel.SetActive(true);
    }

    private string GetFeedback(int water, int soil, int animals, int plants)
    {
        string feedback = "";

        if (water >= 8)
            feedback += "- Je tuin houdt goed water vast.\n";
        else
            feedback += "- Je tuin kan beter omgaan met water in de bodem.\n";

        if (soil >= 8)
            feedback += "- De bodem is goed ondersteund.\n";
        else
            feedback += "- De bodemkwaliteit kan beter.\n";

        if (animals >= 8)
            feedback += "- Je tuin biedt veel voor dieren.\n";
        else
            feedback += "- Er is nog weinig ondersteuning voor dieren.\n";

        if (plants >= 8)
            feedback += "- Je tuin heeft mooie plantdiversiteit.\n";
        else
            feedback += "- Je tuin heeft meer verschillende planten nodig.\n";

        return feedback;
    }
}