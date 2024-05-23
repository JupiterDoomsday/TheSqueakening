using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface Controller
{
    // Update is called once per frame
    void HandleInput(Player player);
    void HandleUpdate(Player player);

    void OnExit();
}
