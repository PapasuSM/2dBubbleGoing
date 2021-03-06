﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
	public GameObject block;
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// 変数speedをかけることでブロックのスピード調整
		float height = 4 * Mathf.Sin(Time.time * speed);
		// 2.0fをblockオブジェクトのYにかけることでより高さを上げる
		block.transform.localPosition =  new Vector2 (0.0f, height);
	}
}
