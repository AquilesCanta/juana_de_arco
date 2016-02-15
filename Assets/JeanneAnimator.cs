using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JeanneAnimator : MonoBehaviour {

	public string[] states = { "idle", "left", "right", "up", "down" };
	public Dictionary<string, KeyCode> keyCodesForStates = new Dictionary<string, KeyCode> {
		{ "idle", KeyCode.None },
		{ "left", KeyCode.LeftArrow },
		{ "right", KeyCode.RightArrow},
		{ "up", KeyCode.UpArrow},
		{ "down", KeyCode.DownArrow },
	};
	public float targetFrameRate = 24.0f;
	public string currentState = "idle";
	private float currentFrameDuration = 0.0f;
	public static int amountOfFrames = 48;
	public Dictionary <string, AnimationState> stateMap = new Dictionary<string, AnimationState>();

	// Use this for initialization
	void Start () {
		foreach (string state in states) {
			AnimationState thisState = new AnimationState ();
			stateMap.Add(state, thisState);
			thisState.sprites = new Sprite[amountOfFrames];
			thisState.trigger = keyCodesForStates [state];
			for (int i = 0; i < amountOfFrames; i++) {
				Texture2D texture = (Texture2D)Resources.Load (state + "/" + state + i);
				thisState.sprites[i] = Sprite.Create (texture,
					new Rect (0, 0, texture.width, texture.height),
					new Vector2 (0.5f, 0.5f));
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
		float frameDuration = 1.0f / targetFrameRate;
		currentFrameDuration += Time.deltaTime;
		if (currentFrameDuration > frameDuration) {
			currentFrameDuration = 0.0f;
			SpriteRenderer renderer = GameObject.Find ("Screen").GetComponent<SpriteRenderer> ();
			AnimationState state = stateMap [currentState];
			bool changePending = state.updateSpriteToRender (renderer);
			if (changePending) {
				currentState = "idle";
				stateMap [currentState].reset ();
			}
			maybeSetNewState ();
		}
	}

	private void maybeSetNewState() {
		// Ver para todos los estados, excepto el actual, si se apreto su tecla.
		foreach (string state in states) {
			if (state.Equals (currentState) || state.Equals("idle")) {
				continue;
			}
			if (stateMap [state].shouldBeActivated ()) {
				stateMap [state].reset ();
				currentState = state;
				return;
			}
		}
	}

	public class AnimationState {
		public int currentFrame = 0;
		public Sprite[] sprites;
		public KeyCode trigger;
		public bool goingForward = true;

		public void reset() {
			currentFrame = 0;
			goingForward = true;
		}

		public bool shouldBeActivated() {
			if (trigger == KeyCode.None) {
				return true;
			}
			return Input.GetKey (trigger);
		}

		public bool updateSpriteToRender(SpriteRenderer renderer) {
			bool shouldChangeState = false;
			if (currentFrame >= JeanneAnimator.amountOfFrames) {
				currentFrame = JeanneAnimator.amountOfFrames - 2;
				goingForward = false;
			} else if (currentFrame < 0) {
				if (Input.GetKey (trigger)) {
					currentFrame = 1;
					goingForward = true;
				} else {
					shouldChangeState = true;
				}
			} else {
				if (trigger != KeyCode.None && !Input.GetKey (trigger)) {
					goingForward = false;
				}
			}
			if (shouldChangeState)
				return true;
			renderer.sprite = sprites [currentFrame];
			currentFrame = goingForward ? currentFrame + 1 : currentFrame -1;
			return false;
		}
	}
}
