using UnityEngine;

public class Spawnner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;

    private void Start()
    {
        // Define a posição X como a borda direita da tela
        float rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right).x + 1f;
        transform.position = new Vector3(rightEdge, 0f, 0f);

        // Começa a chamar o Spawn repetidamente
        InvokeRepeating(nameof(Spawn), 0f, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        // Define uma posição com Y aleatório
        Vector3 spawnPosition = new Vector3(
            transform.position.x,
            Random.Range(minHeight, maxHeight),
            transform.position.z
        );

        Instantiate(prefab, spawnPosition, Quaternion.identity);
    }
}
