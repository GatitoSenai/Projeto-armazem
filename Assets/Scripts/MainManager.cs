using UnityEngine;

public class MainManager : MonoBehaviour
{
public static MainManager Instance;

public Color TeamColor;//linha adicionada

private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
