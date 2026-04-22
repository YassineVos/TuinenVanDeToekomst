using UnityEngine;

public class InteractionSpot : MonoBehaviour
{
    public enum SpotType
    {
        Water,
        Soil,
        Animals,
        Plants
    }

    public SpotType spotType;
    public int scoreAmount = 10;

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

            Interact();
        }
    }

    private void Interact()
    {
        used = true;

        switch (spotType)
        {
            case SpotType.Water:
                ScoreManager.Instance.AddWater(scoreAmount);
                Debug.Log("Je hebt water toegevoegd aan de tuin!");
                break;

            case SpotType.Soil:
                ScoreManager.Instance.AddSoil(scoreAmount);
                Debug.Log("Je hebt de bodem verbeterd!");
                break;

            case SpotType.Animals:
                ScoreManager.Instance.AddAnimals(scoreAmount);
                Debug.Log("Je hebt iets voor dieren toegevoegd!");
                break;

            case SpotType.Plants:
                ScoreManager.Instance.AddPlants(scoreAmount);
                Debug.Log("Je hebt planten toegevoegd!");
                break;
        }

        // visueel feedback (kleur veranderen)
        GetComponentInChildren<Renderer>().material.color = Color.green;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Druk op E om een keuze te maken");
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