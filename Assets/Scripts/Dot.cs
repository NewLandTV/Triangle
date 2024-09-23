using TMPro;
using UnityEngine;

public class Dot : MonoBehaviour
{
    private TextMeshPro text;

    private void Awake()
    {
        text = GetComponentInChildren<TextMeshPro>();
    }

    private void Update()
    {
        string name = gameObject.name;
        float x = transform.position.x;
        float y = transform.position.y;

        text.text = $"{name}({x}, {y})";
    }
}
