using UnityEngine;
using System.Collections;

public class Food  : MonoBehaviour {


	public float FoodAmount = 0.5f;




	// Use this for initialization
	void OnTriggerEnter (Collider ObjectThatTouchedMe)
	{
		if (ObjectThatTouchedMe.tag == "Player") 
		{
			ObjectThatTouchedMe.GetComponent<Teacher.Hunger>().HungerBar.value += FoodAmount;
			Destroy(gameObject);
		}
	}

}





