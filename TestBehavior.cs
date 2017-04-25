using Behavior3CSharp;
using Behavior3CSharp.Core;
using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBehavior : MonoBehaviour {

    private BehaviorTree _tree;
	// Use this for initialization
	void Start () {
        JsonData data = B3Config.Load("TestBehavior3");
        _tree = new BehaviorTree();
        _tree.Load(data);
	}
	
	// Update is called once per frame
	void Update () {
        if (_tree != null)
            _tree.Tick();
	}
}
