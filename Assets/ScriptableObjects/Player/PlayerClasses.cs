using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerClass", menuName = "PlayerClasses")]
public class PlayerClasses : ScriptableObject {

    public new string name;
    public int health;
    public int damage;
    public int movementSpeed;

}
