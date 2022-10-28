using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;


public class Ballscript : MonoBehaviour
{ 
 public Text score;
    int score2;
    public float speed = 100.0f;
    void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed; 
    }
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth) {
        return (ballPos.x - racketPos.x) / racketWidth;
     }
    void onCollisionEnter2D(Collision2D col) {
       if (col.gameObject.name== "racket") { 
        float x=hitFactor(transform.position,
                           col.transform.position, 
                           col.collider.bounds.size.x);
     Vector2 dir = new Vector2(x, 1).normalized;

     GetComponent<Rigidbody2D>().velocity = dir * speed;                       
    }
    if (col.collider.tag == "block")
        { 
            score2++; 
      score.text = score2.ToString();
        }

     /*if (col.gameObject.name== "b1" || col.gameObject.name== "b2" ||col.gameObject.name== "b3" ||col.gameObject.name== "b4" ||col.gameObject.name== "b5" || col.gameObject.name== "b6" ||col.gameObject.name== "b7" ||col.gameObject.name== "b8" ||col.gameObject.name== "b9" ||col.gameObject.name== "b9" ||col.gameObject.name== "b10" ||col.gameObject.name== "b11" ||col.gameObject.name== "b12" ||col.gameObject.name== "b13" ||col.gameObject.name== "b14" ||col.gameObject.name== "b15" ||col.gameObject.name== "b16" ||col.gameObject.name== "b17" ||col.gameObject.name== "b18" ||col.gameObject.name== "b19" ||col.gameObject.name== "b20" ||col.gameObject.name== "b21" || col.gameObject.name== "b22" ||col.gameObject.name== "b23" ||col.gameObject.name== "b24" ||col.gameObject.name== "b25" ||col.gameObject.name== "b26" ||col.gameObject.name== "b27" ||col.gameObject.name== "b28" ||col.gameObject.name== "b29" ||col.gameObject.name== "b30" ) 
      {score2 ++; 
      score.text = score2.ToString();
     }*/
   } 
    
}
