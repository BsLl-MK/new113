using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryTetrisTesting : MonoBehaviour {

    [SerializeField] private Transform outerInventoryTetrisBackground;
    [SerializeField] private InventoryTetris inventoryTetris;
    [SerializeField] private InventoryTetris outerInventoryTetris;
    [SerializeField] private List<string> addItemTetrisSaveList;
    [SerializeField] private GameObject bagplane;
    [SerializeField] private GameObject bagplanebackground;
    [SerializeField] private GameObject testplane;
    [SerializeField] private GameObject testplanebackground;
    private bool openBag;

   private int addItemTetrisSaveListIndex;

    private void Start() {
        outerInventoryTetrisBackground.gameObject.SetActive(false);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            openBag = !openBag;
            testplane.SetActive(openBag);
            testplanebackground.SetActive(openBag);
            //outerInventoryTetrisBackground.gameObject.SetActive(true);
            //outerInventoryTetris.Load(addItemTetrisSaveList[addItemTetrisSaveListIndex]);

            //addItemTetrisSaveListIndex = (addItemTetrisSaveListIndex + 1) % addItemTetrisSaveList.Count;
        }

        if (Input.GetKeyDown(KeyCode.P)) {
            Debug.Log(inventoryTetris.Save());
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            openBag = !openBag;
            bagplane.SetActive(openBag);
            bagplanebackground.SetActive(openBag);
        }
    }
   

}
