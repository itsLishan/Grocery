using UnityEngine;
using System.Collections;


public class SortingHack : MonoBehaviour
{
	public const string LAYER_NAME = "I";
	public int sortingOrder = 3;
	private SpriteRenderer sprite;
	
	void Start()
	{
		sprite = GetComponent<SpriteRenderer>();
		
		if (sprite)
		{
			sprite.sortingOrder = sortingOrder;
			sprite.sortingLayerName = LAYER_NAME;
		}
	}
}
