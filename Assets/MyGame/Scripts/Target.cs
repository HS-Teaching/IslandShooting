using UnityEngine;

public class Target : MonoBehaviour
{
    public GameManager gameManager;

    private void Start()
    {
        //create a reference to the GameManager script
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Destroy(gameObject, 2f);
    }

    private void OnMouseDown()
    {
        //call the IncrementScore() method from the GameManager Script
        gameManager.IncrementScore();
        Destroy(gameObject);
    }
}
