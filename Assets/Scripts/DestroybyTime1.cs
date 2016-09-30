using UnityEngine;
using System.Collections;

public class DestroybyTime1 : MonoBehaviour {
    public float lifetime;
    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
