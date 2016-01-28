using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ExampleTextBehaviour : MonoBehaviour
{
	[System.NonSerialized] public Text thisText;

	public string text
	{
		set
		{
			thisText.text = value;
			StopCoroutine("WaitToErase");
			StartCoroutine("WaitToErase");
		}
  
	}

	void Awake()
	{
		thisText = GetComponent<Text>();
	}

	IEnumerator WaitToErase()
	{
		yield return new WaitForSeconds(0.25f);
		thisText.text = "";
	}
}
