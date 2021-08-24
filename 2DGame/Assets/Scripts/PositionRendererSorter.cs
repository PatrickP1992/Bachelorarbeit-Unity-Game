using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionRendererSorter : MonoBehaviour
{
    [SerializeField]
    private int sortingOrderBase = 5000;
    [SerializeField]
    private int offset = 0;
    private Renderer myRenderer;

    // Start is called before the first frame update
    private void Awake()
    {
        myRenderer = gameObject.GetComponent<Renderer>();

    }

    // Update is called once per frame
    private void Update()
    {
        myRenderer.sortingOrder = (int)(sortingOrderBase - transform.position.y - offset);
    }
}
