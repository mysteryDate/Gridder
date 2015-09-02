using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

	public GameObject player;
	public GameObject[] slots;
	public GameObject currentSlot;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		for(int i = 0; i < 9; i++)
		{
			if(GetComponent<ItemSpawner>().ObjectInventory[i] <= 0)
			{
				slots[i].transform.GetChild (0).gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0.25f);
			}

			else
			{
				slots[i].transform.GetChild (0).gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1);
			}
		}

		slots [9].transform.GetChild (0).gameObject.GetComponent<Text> ().text = GetComponent<ItemSpawner> ().ObjectInventory [GetComponent<ItemSpawner> ().objectIndex] + ".";

//		for(int i = 0; i < 10; i++)
//		{
//			slots[i].SetActive (false);
//		}
		if(Input.GetButtonDown("Inventory"))
		{

			for(int i = 0; i < 10; i++)
			{
				if(!slots[i].activeSelf)
					slots[i].SetActive (true);
				else
					slots[i].SetActive (false);
			}
		}
		GetComponent<RectTransform> ().position = player.transform.position - new Vector3 (0,0,1);
		currentSlot.transform.position =  slots[GetComponent<ItemSpawner>().objectIndex].transform.position;

	}
}
