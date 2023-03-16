using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class itemChecker : MonoBehaviour
{

    
    public int score;
    
    public GameObject ScoreObject;
    
    Text scoreText;

    
    void Start()
    {
        
        scoreText = ScoreObject.GetComponent<Text>();
    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Fishy")
        {
            
            score = score + 1;
            
            scoreText.text = score.ToString();
            
            Destroy(other.gameObject);
        }
       
        if (other.gameObject.tag == "Boom")
        {
            
            score = score - 1;
            
            scoreText.text = score.ToString();
          
            Destroy(other.gameObject);
        }
    }
}
