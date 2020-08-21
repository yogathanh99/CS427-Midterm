using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
  public bool isThrew = false;

	public float speed=20f;

	public Rigidbody2D rb;

	void Update () {
		if (!isThrew){
			rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
		}
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag =="Circle"){
			transform.SetParent(col.transform);
			if (col.GetComponent<Rotator>().isEasy){
				col.GetComponent<Rotator>().speed *=-1;
			}
			else {
				col.GetComponent<Rotator>().speed +=40f;
			}
			Score.Point++;
			isThrew = true;
		} else if (col.tag=="Spear") {
			FindObjectOfType<GameManager>().EndGame();
		}
    }
}
