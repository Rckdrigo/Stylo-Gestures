using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GestureManager : MonoBehaviour
{
	public GameObject swipe, drag, tap, doubleTap, longPress;
	public Toggle swipeToggle, dragToggle, tapToggle, doubleTapToggle, longPressToggle;
	public Text text;

	public void ChangeTypeGesture()
	{
		text.text = "";
		tap.SetActive(tapToggle.isOn);
		doubleTap.SetActive(doubleTapToggle.isOn);
		swipe.SetActive(swipeToggle.isOn);
		drag.SetActive(dragToggle.isOn);
		longPress.SetActive(longPressToggle.isOn);
	}

}

