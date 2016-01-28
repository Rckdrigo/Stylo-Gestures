using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace StyloGestures
{
    public class DoubleTapDetectionExample : DoubleTapGesture
    {

        ExampleTextBehaviour exampleLabel;

        void Start()
        {
            exampleLabel = GameObject.Find("ExampleText").GetComponent<ExampleTextBehaviour>();
        }

        public override void OnDoubleTapDetected()
        {
            exampleLabel.text = "Double Tap!";
        }
    }
}