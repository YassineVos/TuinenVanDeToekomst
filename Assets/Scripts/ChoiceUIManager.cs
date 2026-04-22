using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ChoiceUIManager : MonoBehaviour
{
    public static ChoiceUIManager Instance;

    public GameObject choicePanel;
    public TextMeshProUGUI titleText;

    public Button button1;
    public Button button2;
    public Button button3;

    public TextMeshProUGUI button1Text;
    public TextMeshProUGUI button2Text;
    public TextMeshProUGUI button3Text;

    private InteractionSpot currentSpot;

    private void Awake()
    {
        Instance = this;
        HideChoices();
    }

    public void ShowChoices(InteractionSpot spot)
    {
        currentSpot = spot;
        choicePanel.SetActive(true);

        titleText.text = "Kies een maatregel";

        button1Text.text = "Regenton plaatsen";
        button2Text.text = "Bloemen planten";
        button3Text.text = "Tegels verwijderen";

        button1.onClick.RemoveAllListeners();
        button2.onClick.RemoveAllListeners();
        button3.onClick.RemoveAllListeners();

        button1.onClick.AddListener(() =>
        {
            spot.ApplyChoice(5, 0, 0, 0);
            HideChoices();
        });

        button2.onClick.AddListener(() =>
        {
            spot.ApplyChoice(0, 2, 4, 5);
            HideChoices();
        });

        button3.onClick.AddListener(() =>
        {
            spot.ApplyChoice(4, 3, 0, 0);
            HideChoices();
        });
    }

    public void HideChoices()
    {
        choicePanel.SetActive(false);
        currentSpot = null;
    }
}