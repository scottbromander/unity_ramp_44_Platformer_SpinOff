using UnityEngine;
using System.Collections;

public class PowerUpFlower : Collectable {

	public int itemID = 1;
	public GameObject projectilePrefab;

	override protected void OnCollect(GameObject target){
		var equipedBehavior = target.GetComponent<Equip> ();
		if (equipedBehavior != null) {
			equipedBehavior.currentItem = itemID;
		}

		var shootBehavior = target.GetComponent<FireProjectile> ();
		if (shootBehavior != null) {
			shootBehavior.projectilePrefab = projectilePrefab;
		}
	}
}
