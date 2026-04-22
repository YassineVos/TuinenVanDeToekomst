using UnityEngine;

public class FinishZone : MonoBehaviour
{
    private bool finished = false;

    private void OnTriggerEnter(Collider other)
    {
        if (finished)
            return;

        if (other.CompareTag("Player"))
        {
            finished = true;
            EndUIManager.Instance.ShowEndScreen();
            Debug.Log("Eindscore getoond!");
        }
    }
}