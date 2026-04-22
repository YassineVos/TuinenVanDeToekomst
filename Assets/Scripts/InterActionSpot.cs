using UnityEngine;

public class InteractionSpot : MonoBehaviour
{
    private bool playerInRange = false;
    private bool used = false;

    private void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (used)
            {
                Debug.Log("Deze plek is al gebruikt.");
                return;
            }

            ChoiceUIManager.Instance.ShowChoices(this);
        }
    }

    public void ApplyChoice(int water, int soil, int animals, int plants)
    {
        if (used)
            return;

        used = true;

        ScoreManager.Instance.AddScores(water, soil, animals, plants);

        Debug.Log("Maatregel gekozen!");

        GetComponentInChildren<Renderer>().material.color = Color.green;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Druk op E om een maatregel te kiezen");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }
}