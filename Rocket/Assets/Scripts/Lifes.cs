using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifes : MonoBehaviour
{
    public GameObject Rocket;
    private Health health;
    public Text lifeText;
    // Start is called before the first frame update
    void Start()
    {
        health = Rocket.GetComponent<Health>();
        
      //  lifeText.text = "Lifes remaining: " + Health.numberOfLives.ToString();
    }
    
    // Update is called once per frame
    void Update()
    {
        lifeText.text = $"Lifes remaining: {health.numberOfLives - 1}";
    }
}
