using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour {

	public Rigidbody2D rb;
    public static float width = 1f, height = 1f;

	public static float minSpeed = 8f;
	public static float maxSpeed = 12f;

	float speed = 1f;

	void Start ()
	{
		speed = Random.Range(minSpeed, maxSpeed);
	}

	void FixedUpdate () {
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
	}
     void Awake()
    {
        Vector3 scale = new Vector3(width, height, 1f);
        transform.localScale = scale;
    }
}
