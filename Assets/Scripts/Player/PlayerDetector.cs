using UnityEngine;
using UnityEngine.UI;

public class PlayerDetector : MonoBehaviour
{
    public GameOverManager gameOverManager;
    public Text text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && !other.isTrigger)
        {
            float enemyDistance = Vector3.Distance(transform.position, other.transform.position);
            text.text = "! " + enemyDistance;
            gameOverManager.ShowWarning(enemyDistance);
        }
    }
}