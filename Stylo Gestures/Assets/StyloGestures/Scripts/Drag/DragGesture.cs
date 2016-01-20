using UnityEngine;
using System.Collections;
using UnityEngine.Assertions;

namespace StyloGestures{
	public class DragGesture : MonoBehaviour {

		#region Core
		private bool dragging;
		private Vector2 lastPosition,actualPosition;

		public virtual void Update () {
			#if UNITY_EDITOR
			if(Input.GetMouseButton(0)){
				dragging = true;
				actualPosition = Input.mousePosition;
				if(lastPosition!=null){
					if(lastPosition != actualPosition)
						OnDraggingDetected(actualPosition,(actualPosition-lastPosition).normalized);
					else
						OnLongPressDetected(actualPosition);
				}
			}
			#else
			if(Input.touchCount == 1){
				dragging = true;
				actualPosition = Input.GetTouch(0).position;
				if(Input.GetTouch(0).phase == TouchPhase.Moved){
					if(lastPosition!=null)
						OnDraggingDetected(actualPosition,(actualPosition-lastPosition).normalized);
				}else if(Input.GetTouch(0).phase == TouchPhase.Stationary)
					OnPressDetected(actualPosition);
			}
			#endif
		}

		public virtual void LateUpdate(){
			if(dragging){
				lastPosition = actualPosition;
			}
		}
		#endregion

		#region Public Methods
		public virtual void OnDraggingDetected(Vector2 screenPosition, Vector2 direction){}
		public virtual void OnLongPressDetected(Vector2 screenPosition){}
		#endregion
	}
}
