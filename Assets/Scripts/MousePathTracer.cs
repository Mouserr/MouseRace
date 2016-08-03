using System.Collections.Generic;
using Assets.Helpers;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class MousePathTracer : MonoBehaviour
    {
        [SerializeField] 
        private Image dotPrefab;
        [SerializeField]
        private int valuesCount = 150;
        
        private Queue<Image> dots;


        private void Awake()
        {
            dots = new Queue<Image>(valuesCount);
            for (int i = 0; i < valuesCount; i++)
            {
                Image image = PrefabHelper.Intantiate(dotPrefab, gameObject);
                image.color = Color.clear;
                dots.Enqueue(image);
            }
        }

        private void Update()
        {
            if (!Input.GetMouseButton(0)) return;
            Image image = dots.Dequeue();
            image.color = Color.red;
            image.transform.position = Input.mousePosition;
            dots.Enqueue(image);
        }

    }
}