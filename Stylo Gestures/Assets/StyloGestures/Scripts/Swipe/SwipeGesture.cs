using UnityEngine;
using System;
using System.Collections;

namespace StyloGestures{

	[Serializable] public enum SwipeDirection{Left,Right,Up,Down,NULL}

/// <summary>
/// Swipe gesture. This class automatically detects and calls one of five different methods. 
/// Simple, Raw, Normalized, Radian angle, Degree angle
/// </summary>
	[HelpURL("https://github.com/Rckdrigo/Stylo-Gestures/wiki/Swipe-Gesture")]
	public abstract class SwipeGesture : MonoBehaviour {

		[Range(0.00f,0.2f)] public float swipeTimePrecision = 0.045f;
		[Range(0,200)] public float swipeLengthPrecision = 50f;
		#region Core
		private bool onMovement = false;
		private Vector2 initialPosition, finalPosition; 
		private Vector2 swipeDirectionVector;
		private Vector2 swipeRawDirectionVector;


		public virtual void Update () {
			#if !UNITY_EDITOR
			if(Input.touchCount == 1){
				if(Input.GetTouch(0).phase == TouchPhase.Moved) {
					if(!onMovement){
						initialPosition = Input.GetTouch(0).position;
						StopAllCoroutines();
						StartCoroutine(CheckIfGesture());
						onMovement = true;
					}
				}
			}
			#else
				if(Input.GetMouseButton(0)){
					if(!onMovement){
						initialPosition = (Vector2)Input.mousePosition;
						StopAllCoroutines();
						StartCoroutine(CheckIfGesture());
						onMovement = true;
					}
				}
			#endif
		}

		private IEnumerator CheckIfGesture(){
			yield return new WaitForSeconds(swipeTimePrecision);
		#if UNITY_EDITOR
			if(Input.GetMouseButton(0))
				finalPosition = (Vector2)Input.mousePosition;
		#else
			if(Input.touchCount > 0)
				finalPosition = Input.GetTouch(0).position;
		#endif
			if(Vector3.Distance(finalPosition,initialPosition) > swipeLengthPrecision){
				Vector2 direction = (finalPosition - initialPosition);
				swipeRawDirectionVector = direction;
				OnSwipeRawDetected(swipeRawDirectionVector);
				swipeDirectionVector = new Vector2(Mathf.Round(Vector2.Dot(direction,Vector2.right)),Mathf.Round(Vector2.Dot(direction,Vector2.up))).normalized;
				OnSwipeNormalizedDetected(swipeDirectionVector);
				OnSwipeRadianDetected(Mathf.Atan2(swipeRawDirectionVector.y,swipeRawDirectionVector.x),swipeRawDirectionVector.magnitude);
				OnSwipeDegreeDetected(Mathf.Atan2(swipeRawDirectionVector.y,swipeRawDirectionVector.x)*180f/Mathf.PI,swipeRawDirectionVector.magnitude);
				OnSwipeSimpleDetected(GetDirection());


			}
			onMovement = false;
		}

		private SwipeDirection GetDirection(){
			if(Vector2.Dot(swipeRawDirectionVector.normalized,Vector2.up) > 0.5f)
				return SwipeDirection.Up;
			else if(Vector2.Dot(swipeRawDirectionVector.normalized,Vector2.down) > 0.5f)
				return SwipeDirection.Down;
			else if(Vector2.Dot(swipeRawDirectionVector.normalized,Vector2.right) > 0.5f)
				return SwipeDirection.Right;
			else if(Vector2.Dot(swipeRawDirectionVector.normalized,Vector2.left) > 0.5f)
				return SwipeDirection.Left;
			return SwipeDirection.NULL;
		}

		#endregion

		#region Public methods
		/// <summary>
		/// This methods gives you the direction as a simple enumeration: Up, down, left, right
		/// </summary>
		public virtual void OnSwipeSimpleDetected(SwipeDirection direction){}

		/// <summary>
		/// This methods gives you the direction as a Vector2 with the raw values of (x,y)
		/// </summary>
		public virtual void OnSwipeRawDetected(Vector2 direction){}

		/// <summary>
		/// This methods gives you the direction as a Vector2 with the normalized values (between [-1,1]) in (x,y)
		/// </summary>
		public virtual void OnSwipeNormalizedDetected(Vector2 direction){}

		/// <summary>
		/// This methods gives you the direction as an angle in radians
		/// </summary>
		public virtual void OnSwipeRadianDetected(float angle, float radius){}

		/// <summary>
		/// This methods gives you the direction as an angle in degrees
		/// </summary>
		public virtual void OnSwipeDegreeDetected(float angle, float radius){}
		#endregion
	}
}
