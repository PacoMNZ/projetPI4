using System;
using UnityEngine;
using UnityEngine.Events;

public class BoxPanel : PanelController {

    public UnityEvent onBuyBox;
	private IExampleManager _exampleManager;

    // <summary>
    // To be called when the "Buy lootbox" button is selected.
    // </summary>
    public void OnBuyBoxButtonClicked() {
        _exampleManager = ExampleFactory.Instance.GetExampleManager();
        _exampleManager.BuyBox();
    }

}