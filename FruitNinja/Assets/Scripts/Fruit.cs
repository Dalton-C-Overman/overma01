using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Fruit : MonoBehaviour {

	public GameObject fruitSlicedPrefab;
	public static float startForce = 15f;


	public static Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
        //Physics.gravity = new Vector3(0, FruitSpawner.gravity, 0);
    }

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Blade")
		{
			Vector3 direction = (col.transform.position - transform.position).normalized;

			Quaternion rotation = Quaternion.LookRotation(direction);

			GameObject slicedFruit = Instantiate(fruitSlicedPrefab, transform.position, rotation);
            slicedFruit.transform.localScale = new Vector3(FruitSpawner.size, FruitSpawner.size, FruitSpawner.size);
            Destroy(slicedFruit, 3f);
			Destroy(gameObject);
            Scorer.updateScore();
        }
	}

}
