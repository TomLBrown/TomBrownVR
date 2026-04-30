using UnityEngine;

public class Flame : MonoBehaviour
{
    [SerializeField] string tagFilter;
    public GameObject flameEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flameEffect.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (!string.IsNullOrEmpty(tagFilter) && !other.gameObject.CompareTag(tagFilter)) return;

        flameEffect.SetActive(true);
    }
}
