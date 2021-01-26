﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BroomController : MonoBehaviour
{
    public Text scoreText;
    public int score;

    private RacconSpawner ms;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        ms = GetComponent<RacconSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetButtonDown("Fire1") && ms.gameTime > 0)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if(hit.transform.gameObject != null)
            {
                Destroy(hit.transform.gameObject);
                score += 1;
                scoreText.text = score.ToString();
                ms.Spawn();
            }
        }
        
    }
}
