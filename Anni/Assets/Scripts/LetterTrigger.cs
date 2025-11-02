using System;
using System.Collections.Generic;
using UnityEngine;

public class LetterTrigger : MonoBehaviour
{
    public List<GameObject> letters = new List<GameObject>();
    int index = 0;
    public GameObject letterPrefab;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("is player");
            Vector2 offset = new Vector2(-3, 0);
            Instantiate(letterPrefab, offset, Quaternion.identity);
            Debug.Log("set active letters");
        }
    }
}
