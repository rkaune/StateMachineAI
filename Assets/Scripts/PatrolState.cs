using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using BasicAI;

public class PatrolState : BaseState
{
	public enum PatrolType {
		Loop,
		PingPong
	}

	private GameObject player;
	private NavMeshAgent agent;

	private Transform[] waypoints;
	private PatrolType behavior;

	public PatrolState(GameObject actor, GameObject player, Transform[] waypoints, PatrolType behavior = PatrolType.PingPong) {
		this.waypoints = waypoints;
		this.behavior = behavior;

		this.player = player;
		agent = actor.GetComponent<NavMeshAgent>();
	}

    public override Type Tick() {
		if (Input.GetKeyDown(KeyCode.Space)) {
			return typeof(IdleState);
		}
		return null;
	}
}
